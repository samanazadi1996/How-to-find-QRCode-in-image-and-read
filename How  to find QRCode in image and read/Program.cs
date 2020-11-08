using BC.NetBarcodeReaderTrial.All;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace How__to_find_QRCode_in_image_and_read
{
    class Program
    {
        static void Main(string[] args)
        {
            var image = "C://versions-qr-codes.png";
            ReadAllQRCodeTypefromImage(image);
            Console.ReadKey();
        }
        public static void ReadAllQRCodeTypefromImage(string fileUrl)
        {
            string[] data = NetBarcodeReader.Recognize(fileUrl, NetBarcodeReader.Qrcode);
            foreach (string result in data)
            {
                Console.WriteLine(result);
            }
        }
    }
}
