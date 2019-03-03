using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rhino.Mocks;
using ThirdPartyTools;
using Wrappers;

namespace ThirdPartyToolsWrapperTest
{
    [TestClass]
    public class UnitTest1
    {

        private FileDetails _fileDetails;
        private MockRepository _mocks;
        private ThirdPartyToolsWrapper _thirdPartyToolsWrapper;

        [TestInitialize]
        public void TestInitialize()
        {
            _mocks = new MockRepository();
            _fileDetails = _mocks.StrictMock<FileDetails>();
            _thirdPartyToolsWrapper = new ThirdPartyToolsWrapper(_fileDetails);

        }

        [TestMethod]
        public void ThirdPartyToolsWrapper_VersionCall_VersionMethodOfFilesDetailIsCalled()
        {
            using (_mocks.Record())
            {
                _fileDetails.Version("a file path");
            }

            using (_mocks.Playback())
            {
                _thirdPartyToolsWrapper.Version("a file path");
            }
        }

        [TestMethod]
        public void ThirdPartyToolsWrapper_SizeCall_SizeMethodOfFilesDetailIsCalled()
        {
            using (_mocks.Record())
            {
                _fileDetails.Size("a file path");
            }

            using (_mocks.Playback())
            {
                _thirdPartyToolsWrapper.Size("a file path");
            }
        }


        [TestCleanup]
        public void TestCleanup()
        {
            _mocks = null;
            _fileDetails = null;
            _thirdPartyToolsWrapper = null;
        }
    }

}
