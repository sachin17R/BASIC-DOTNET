using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Xml.Serialization;

namespace FrameWorksApp.Serialization
{
    [Serializable]
   public class AccountClass
    {
        public int HolderNo { get; set; }
        public string HolderName { get; set; }
        public string HolderAddress { get; set; }
        public override string ToString()
        {
            return $"{HolderName} from {HolderAddress} of Id {HolderNo} ";
        }
    }
    class SerializationExamples
    {
        static void Main(string[] args)
        {
            BinarySerializationfunc();
            BinaryDeserializationfunc();
            xmlserializationfunc();
            xmlDeSerializationfunc();
            soapSerializationFunc();
            soapDeSerializationFunc();

        }

        private static void soapDeSerializationFunc()
        {
            AccountClass acc = null;
            FileStream fs = new FileStream("accsoap.xml", FileMode.Open, FileAccess.Read);
            SoapFormatter sf = new SoapFormatter();
           acc= sf.Deserialize(fs) as AccountClass;


            fs.Close();
            Console.WriteLine(acc);
            return;
        }

        private static void soapSerializationFunc()
        {
            AccountClass acc = new AccountClass { HolderNo = 111, HolderName = "pavan", HolderAddress = "bangalore" };
            FileStream fs = new FileStream("accsoap.xml", FileMode.OpenOrCreate, FileAccess.Write);
            SoapFormatter soap = new SoapFormatter();
            soap.Serialize(fs, acc);
            fs.Close();
            return;
        }

        private static void xmlDeSerializationfunc()
        {
            AccountClass acc = null;
            FileStream fs1 = new FileStream("Acc1.xml", FileMode.Open, FileAccess.Read);
            XmlSerializer sr = new XmlSerializer(typeof(AccountClass));
            acc= sr.Deserialize(fs1) as AccountClass;
            fs1.Close();
            Console.WriteLine(acc);
            return;
        }

        private static void xmlserializationfunc()
        {
            AccountClass acc = new AccountClass { HolderNo = 123, HolderName = "sachin", HolderAddress = "bangalore" };
            FileStream fs1 = new FileStream("Acc1.xml", FileMode.OpenOrCreate, FileAccess.Write);
            XmlSerializer sr = new XmlSerializer(typeof(AccountClass));
            sr.Serialize(fs1, acc);
            fs1.Close();
            return;
        }

        private static void BinaryDeserializationfunc()
        {
            AccountClass acc = null;
            FileStream fs = new FileStream("Acc.Bin", FileMode.Open, FileAccess.Read);
            BinaryFormatter formatter = new BinaryFormatter();
           acc = formatter.Deserialize(fs) as AccountClass;
            Console.WriteLine(acc.ToString());
            return;
        }

        private static void BinarySerializationfunc()
        {
            AccountClass acc = new AccountClass { HolderNo = 111, HolderName = "Sachin R", HolderAddress = "Mysore" };

            FileStream fs = new FileStream("Acc.Bin", FileMode.OpenOrCreate, FileAccess.Write);
            BinaryFormatter formattor = new BinaryFormatter();
            formattor.Serialize(fs, acc);
            fs.Close();
            return;
        }
    }
}
