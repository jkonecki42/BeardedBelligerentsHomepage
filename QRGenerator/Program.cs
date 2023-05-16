using IronBarCode;

// Creating a barcode is as simple as:
var myQRcode = QRCodeWriter.CreateQrCode("https://metalforall.azurewebsites.net", 500);
// After creating a barcode, we may choose to resize and save which is easily done with:
myQRcode.SaveAsImage("BeardedBelligerentsHomepage.jpg");