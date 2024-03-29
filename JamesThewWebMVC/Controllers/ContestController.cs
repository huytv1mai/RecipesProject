﻿using DataAccess.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace JamesThewWebMVC.Controllers
{
    public class ContestController : Controller
    {
        private readonly JamesThewDbContext _db;
        public ContestController(JamesThewDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var listContest = _db.Contests.ToList();
            if (User.Identity.IsAuthenticated)
            {
                var email = User.FindFirst(ClaimTypes.Email)?.Value;
                var _userId = _db.UserDetails.First(x => x.Email.Contains(email)).UserId;
                //listContest = _db.Contests
                //               .Join(
                //                   _db.Participants.Where(p => p.UserId != _userId),
                //                   ct => ct.ContestId,
                //                   p => p.ContestId,
                //                   (ct, p) => new { ct, p }
                //               )
                //               .Where(x => x.ct.StartDate <= DateTime.Now && x.ct.EndDate >= DateTime.Now && !_db.Participants.Any(p => p.ContestId == ct.ContestId && p.UserId == _userId))
                //               .Select(x => x.ct).ToList();
                listContest = _db.Contests
            .Where(ct => ct.StartDate <= DateTime.Now && ct.EndDate >= DateTime.Now && !_db.Participants.Any(p => p.ContestId == ct.ContestId && p.UserId == _userId))
            .ToList();
                //var checkContest = _db.Participants.Where(x => x.UserId == _userId);

            }
            return View(listContest);
        }
        [Authorize]
        [HttpPost]
        public IActionResult ParticipantContest(int contestId)
        {
            if (User.Identity.IsAuthenticated)
            {
                try
                {
                    var email = User.FindFirst(ClaimTypes.Email)?.Value;
                    var _userId = _db.UserDetails.First(x => x.Email.Contains(email)).UserId;
                    var _participant = new Participant { UserId = _userId, ContestId = contestId };
                    _db.Participants.Add(_participant);
                    _db.SaveChanges();
                    return Json(new { success = true });
                }
                catch (Exception ex)
                {
                    // Xử lý lỗi ở đây nếu cần thiết
                    return Json(new { success = false });
                }
            }
            else
            {
                return Json(new { success = false });
            }
        }
    }
}
