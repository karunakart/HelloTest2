﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace UploadFile
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the HelloRepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.1")]
    [RepositoryFolder("798fb687-9336-4b77-9fc5-dfc140d651cd")]
    public partial class HelloRepository : RepoGenBaseFolder
    {
        static HelloRepository instance = new HelloRepository();
        HelloRepositoryFolders.FileuploadPageAppFolder _fileuploadpage;
        HelloRepositoryFolders.NewFolderFolder _newfolder;
        HelloRepositoryFolders.ComEdAppFolder _comed;

        /// <summary>
        /// Gets the singleton class instance representing the HelloRepository element repository.
        /// </summary>
        [RepositoryFolder("798fb687-9336-4b77-9fc5-dfc140d651cd")]
        public static HelloRepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public HelloRepository() 
            : base("HelloRepository", "/", null, 0, false, "798fb687-9336-4b77-9fc5-dfc140d651cd", ".\\RepositoryImages\\HelloRepository798fb687.rximgres")
        {
            _fileuploadpage = new HelloRepositoryFolders.FileuploadPageAppFolder(this);
            _newfolder = new HelloRepositoryFolders.NewFolderFolder(this);
            _comed = new HelloRepositoryFolders.ComEdAppFolder(this);
        }

#region Variables

        string _sk = "";

        /// <summary>
        /// Gets or sets the value of variable sk.
        /// </summary>
        [TestVariable("076712ac-500d-41db-81ce-3df128292278")]
        public string sk
        {
            get { return _sk; }
            set { _sk = value; }
        }

        string _CustomerPortalDom1 = "";

        /// <summary>
        /// Gets or sets the value of variable CustomerPortalDom1.
        /// </summary>
        [TestVariable("8b1fd1a2-dd2a-4f89-a454-5869422f5168")]
        public string CustomerPortalDom1
        {
            get { return _CustomerPortalDom1; }
            set { _CustomerPortalDom1 = value; }
        }

        string _CustomerPortalDom2 = "";

        /// <summary>
        /// Gets or sets the value of variable CustomerPortalDom2.
        /// </summary>
        [TestVariable("ad679993-f759-4a0d-8661-05ce87dd87df")]
        public string CustomerPortalDom2
        {
            get { return _CustomerPortalDom2; }
            set { _CustomerPortalDom2 = value; }
        }

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("798fb687-9336-4b77-9fc5-dfc140d651cd")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The FileuploadPage folder.
        /// </summary>
        [RepositoryFolder("5a1666c1-5747-4aef-a4d2-30c7aa95ee90")]
        public virtual HelloRepositoryFolders.FileuploadPageAppFolder FileuploadPage
        {
            get { return _fileuploadpage; }
        }

        /// <summary>
        /// The NewFolder folder.
        /// </summary>
        [RepositoryFolder("ba08fe35-305b-4552-9eea-cc7f5a416ee9")]
        public virtual HelloRepositoryFolders.NewFolderFolder NewFolder
        {
            get { return _newfolder; }
        }

        /// <summary>
        /// The ComEd folder.
        /// </summary>
        [RepositoryFolder("3dc309ae-f5a1-4063-866a-e6429a17f362")]
        public virtual HelloRepositoryFolders.ComEdAppFolder ComEd
        {
            get { return _comed; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.1")]
    public partial class HelloRepositoryFolders
    {
        /// <summary>
        /// The FileuploadPageAppFolder folder.
        /// </summary>
        [RepositoryFolder("5a1666c1-5747-4aef-a4d2-30c7aa95ee90")]
        public partial class FileuploadPageAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _fileuploadlinkInfo;

            /// <summary>
            /// Creates a new FileuploadPage  folder.
            /// </summary>
            public FileuploadPageAppFolder(RepoGenBaseFolder parentFolder) :
                    base("FileuploadPage", "/dom[@domain='encodable.com']", parentFolder, 30000, null, false, "5a1666c1-5747-4aef-a4d2-30c7aa95ee90", "")
            {
                _fileuploadlinkInfo = new RepoItemInfo(this, "FIleuploadLInk", ".//input[#'uploadname1']", 30000, null, "eec096b6-7342-4584-9f4c-5a727517cf48");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("5a1666c1-5747-4aef-a4d2-30c7aa95ee90")]
            public virtual Ranorex.WebDocument Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.WebDocument>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("5a1666c1-5747-4aef-a4d2-30c7aa95ee90")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The FIleuploadLInk item.
            /// </summary>
            [RepositoryItem("eec096b6-7342-4584-9f4c-5a727517cf48")]
            public virtual Ranorex.InputTag FIleuploadLInk
            {
                get
                {
                    return _fileuploadlinkInfo.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The FIleuploadLInk item info.
            /// </summary>
            [RepositoryItemInfo("eec096b6-7342-4584-9f4c-5a727517cf48")]
            public virtual RepoItemInfo FIleuploadLInkInfo
            {
                get
                {
                    return _fileuploadlinkInfo;
                }
            }
        }

        /// <summary>
        /// The NewFolderFolder folder.
        /// </summary>
        [RepositoryFolder("ba08fe35-305b-4552-9eea-cc7f5a416ee9")]
        public partial class NewFolderFolder : RepoGenBaseFolder
        {
            HelloRepositoryFolders.OpenAppFolder _open;

            /// <summary>
            /// Creates a new NewFolder  folder.
            /// </summary>
            public NewFolderFolder(RepoGenBaseFolder parentFolder) :
                    base("NewFolder", "", parentFolder, 0, null, false, "ba08fe35-305b-4552-9eea-cc7f5a416ee9", "")
            {
                _open = new HelloRepositoryFolders.OpenAppFolder(this);
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("ba08fe35-305b-4552-9eea-cc7f5a416ee9")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The Open folder.
            /// </summary>
            [RepositoryFolder("ed5af4ed-adaa-4bee-999e-3f6a65520d82")]
            public virtual HelloRepositoryFolders.OpenAppFolder Open
            {
                get { return _open; }
            }
        }

        /// <summary>
        /// The OpenAppFolder folder.
        /// </summary>
        [RepositoryFolder("ed5af4ed-adaa-4bee-999e-3f6a65520d82")]
        public partial class OpenAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _text1148Info;
            RepoItemInfo _buttonopenInfo;

            /// <summary>
            /// Creates a new Open  folder.
            /// </summary>
            public OpenAppFolder(RepoGenBaseFolder parentFolder) :
                    base("Open", "/form[@title='Open']", parentFolder, 30000, null, true, "ed5af4ed-adaa-4bee-999e-3f6a65520d82", "")
            {
                _text1148Info = new RepoItemInfo(this, "Text1148", "?/?/text[@controlid='1148']", 30000, null, "f38b0f7c-e955-4bea-9baf-37c52633fa79");
                _buttonopenInfo = new RepoItemInfo(this, "ButtonOpen", "button[@text='&Open']", 30000, null, "ba8ea290-77ee-4021-8ad6-197a44a13be2");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("ed5af4ed-adaa-4bee-999e-3f6a65520d82")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("ed5af4ed-adaa-4bee-999e-3f6a65520d82")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The Text1148 item.
            /// </summary>
            [RepositoryItem("f38b0f7c-e955-4bea-9baf-37c52633fa79")]
            public virtual Ranorex.Text Text1148
            {
                get
                {
                    return _text1148Info.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The Text1148 item info.
            /// </summary>
            [RepositoryItemInfo("f38b0f7c-e955-4bea-9baf-37c52633fa79")]
            public virtual RepoItemInfo Text1148Info
            {
                get
                {
                    return _text1148Info;
                }
            }

            /// <summary>
            /// The ButtonOpen item.
            /// </summary>
            [RepositoryItem("ba8ea290-77ee-4021-8ad6-197a44a13be2")]
            public virtual Ranorex.Button ButtonOpen
            {
                get
                {
                    return _buttonopenInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The ButtonOpen item info.
            /// </summary>
            [RepositoryItemInfo("ba8ea290-77ee-4021-8ad6-197a44a13be2")]
            public virtual RepoItemInfo ButtonOpenInfo
            {
                get
                {
                    return _buttonopenInfo;
                }
            }
        }

        /// <summary>
        /// The ComEdAppFolder folder.
        /// </summary>
        [RepositoryFolder("3dc309ae-f5a1-4063-866a-e6429a17f362")]
        public partial class ComEdAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _lnkbtnuploadnewboxInfo;

            /// <summary>
            /// Creates a new ComEd  folder.
            /// </summary>
            public ComEdAppFolder(RepoGenBaseFolder parentFolder) :
                    base("ComEd", "/dom[@domain=$CustomerPortalDom1 or @domain=$CustomerPortalDom2 or @visible='True']", parentFolder, 30000, null, false, "3dc309ae-f5a1-4063-866a-e6429a17f362", "")
            {
                _lnkbtnuploadnewboxInfo = new RepoItemInfo(this, "LnkBtnUploadNewBox", ".//a[#'lnkBtnUploadNewBox']", 30000, null, "8b472d5d-e150-4b23-a0e3-635567a818f7");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("3dc309ae-f5a1-4063-866a-e6429a17f362")]
            public virtual Ranorex.WebDocument Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.WebDocument>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("3dc309ae-f5a1-4063-866a-e6429a17f362")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The LnkBtnUploadNewBox item.
            /// </summary>
            [RepositoryItem("8b472d5d-e150-4b23-a0e3-635567a818f7")]
            public virtual Ranorex.ATag LnkBtnUploadNewBox
            {
                get
                {
                    return _lnkbtnuploadnewboxInfo.CreateAdapter<Ranorex.ATag>(true);
                }
            }

            /// <summary>
            /// The LnkBtnUploadNewBox item info.
            /// </summary>
            [RepositoryItemInfo("8b472d5d-e150-4b23-a0e3-635567a818f7")]
            public virtual RepoItemInfo LnkBtnUploadNewBoxInfo
            {
                get
                {
                    return _lnkbtnuploadnewboxInfo;
                }
            }
        }

    }
#pragma warning restore 0436
}