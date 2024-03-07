(function ($) {
    $(document).ready(function () {
        $('#Content').summernote({
            height: 300,
            minHeight: null,
            maxHeight: null,
            focus: true, 
            codemirror: {
                theme: "monokai"
            },
            callbacks: {
                onImageUpload: function (files) {
                    for (var i = 0; i < files.length; i++) {
                        uploadImage(files[i]);
                    }
                }
            },
            fontSizes: ['12', '14', '16', '18', '24', '36', '48'],
            toolbar: [
                ['style', ['style']],
                ['font', ['bold', 'underline', 'clear']],
                ['fontname', ['fontname']],
                ['fontsize', ['fontsize']],
                ['color', ['color']],
                ['para', ['ul', 'ol', 'paragraph']],
                ['table', ['table']],
                ['insert', ['link', 'picture', 'video']],
                ['view', ['fullscreen', 'codeview', 'help']]
            ] 
        });
    });
    function uploadImage(file) {
        var formData = new FormData();
        formData.append("uploadedFiles", file);
        $.ajax({
            data: formData,
            type: "POST",
            url: '/Post/UploadFile',
            cache: false,
            contentType: false,
            processData: false,
            success: function (FileUrl) {
                alert(FileUrl);
                var imgNode = document.createElement('img');
                imgNode.src = FileUrl;
                $('.content-editor').summernote('insertNode', imgNode);
            },
            error: function (data) {
                alert(data.responseText);
            }
        });
    }
})(jQuery);
