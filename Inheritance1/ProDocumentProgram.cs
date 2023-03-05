using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance1
{
    class ProDocumentProgram : DocumentProgram
    {
        public override void EditDocument()
        {
            Console.WriteLine("DocumentEdited");
        }

        public override void SaveDocument()
        {
            Console.WriteLine("Document Saved in doc format,");
        }
    }
}