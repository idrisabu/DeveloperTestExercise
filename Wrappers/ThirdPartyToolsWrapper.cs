using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThirdPartyTools;

namespace Wrappers
{
    public class ThirdPartyToolsWrapper
    {
        private FileDetails _fileDetails;
        public ThirdPartyToolsWrapper(FileDetails fileDetails)
        {
            _fileDetails = fileDetails;
        }
        public int Size(string filePath)
        {
            return _fileDetails.Size(filePath);
        }

        public string Version(string filePath)
        {
            return _fileDetails.Version(filePath);
        }
    }
}
