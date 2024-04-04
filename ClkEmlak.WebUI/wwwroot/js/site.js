document.getElementById("file-input").addEventListener("change", function (event) {
    var preview = document.getElementById("file-preview");
    preview.innerHTML = "";

    var files = event.target.files;
    for (var i = 0; i < files.length; i++) {
        var file = files[i];

        var reader = new FileReader();

        reader.onload = function (event) {
            var img = document.createElement("img");
            img.src = event.target.result;

            var div = document.createElement("div");
            div.className = "preview-item";
            div.appendChild(img);

            //var closeButton = document.createElement("button");
            //closeButton.innerHTML = "&times;";
            //closeButton.className = "close-icon";
            //closeButton.addEventListener("click", function () {
            //    div.remove();
            //    updateFileCount();

            //    // Resmi FormData'dan kaldır
            //    var fileName = img.src.split("/").pop(); // Resim dosya adını al
            //    removeImageFromFormData(fileName);
            //});
            //div.appendChild(closeButton);

            preview.appendChild(div);
            updateFileCount();
        };

        reader.readAsDataURL(file);
    }
});

function updateFileCount() {
    var fileCount = document.querySelectorAll("#file-preview .preview-item").length;
    var label = document.querySelector("label[for='file-input'] span");
    label.textContent = "Resim Seç (" + fileCount + ")";
}


function removeImageFromFormData(fileName) {
    var formData = new FormData(document.getElementById("upload-form"));
    var images = formData.getAll("Images"); // Tüm resimlerin listesini al
    formData.delete("Images"); // Mevcut resimleri FormData'dan kaldır

    // Kaldırılacak resmi dışındaki tüm resimleri FormData'ya geri ekle
    images.forEach(function (image) {
        if (image.name !== fileName) {
            formData.append("Images", image);
        }
    });
}

updateFileCount();