# How-to-find-QRCode-in-image-and-read
To find QRCode in a photo and read it, you can follow the example below or download the project and view it

Create a new project to start

Then add the following dll to the project ----> BC.NetBarcodeReaderTrial.All

Link download dll  ----> https://file.io/8lo0tKEqIC7I

Add the BC.NetBarcodeReaderTrial.All Library to the project ----> using BC.NetBarcodeReaderTrial.All;

After completing the previous steps, you can download the entire QrCodes inside the image and read the content by writing the sample code below.

  var fileUrl = "c://image.jpg";
  
  string[] data = NetBarcodeReader.Recognize(fileUrl, NetBarcodeReader.Qrcode);
  
  foreach (string result in data)
  
  {
  
  Console.WriteLine(result);
  
  }
