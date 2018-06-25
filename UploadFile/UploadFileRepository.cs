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
    /// The class representing the UploadFileRepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.1")]
    [RepositoryFolder("b6713d9c-3c56-48d8-aa66-11ed1a770bf6")]
    public partial class UploadFileRepository : RepoGenBaseFolder
    {
        static UploadFileRepository instance = new UploadFileRepository();
        UploadFileRepositoryFolders.ComEdAppFolder _comed;
        UploadFileRepositoryFolders.NewFolderFolder _newfolder;
        UploadFileRepositoryFolders.FileuploadPageAppFolder _fileuploadpage;

        /// <summary>
        /// Gets the singleton class instance representing the UploadFileRepository element repository.
        /// </summary>
        [RepositoryFolder("b6713d9c-3c56-48d8-aa66-11ed1a770bf6")]
        public static UploadFileRepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public UploadFileRepository() 
            : base("UploadFileRepository", "/", null, 0, false, "b6713d9c-3c56-48d8-aa66-11ed1a770bf6", ".\\RepositoryImages\\UploadFileRepositoryb6713d9c.rximgres")
        {
            _comed = new UploadFileRepositoryFolders.ComEdAppFolder(this);
            _newfolder = new UploadFileRepositoryFolders.NewFolderFolder(this);
            _fileuploadpage = new UploadFileRepositoryFolders.FileuploadPageAppFolder(this);
        }

#region Variables

        string _CustomerPortalDom1 = "";

        /// <summary>
        /// Gets or sets the value of variable CustomerPortalDom1.
        /// </summary>
        [TestVariable("542dd990-feaf-45f9-a5a3-2b23347be2ae")]
        public string CustomerPortalDom1
        {
            get { return _CustomerPortalDom1; }
            set { _CustomerPortalDom1 = value; }
        }

        string _CustomerPortalDom2 = "";

        /// <summary>
        /// Gets or sets the value of variable CustomerPortalDom2.
        /// </summary>
        [TestVariable("fdb7f89b-f840-48e3-bfc3-92c10ea14357")]
        public string CustomerPortalDom2
        {
            get { return _CustomerPortalDom2; }
            set { _CustomerPortalDom2 = value; }
        }

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("b6713d9c-3c56-48d8-aa66-11ed1a770bf6")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The ComEd folder.
        /// </summary>
        [RepositoryFolder("335b0c43-5f21-4662-8203-dc57658a3698")]
        public virtual UploadFileRepositoryFolders.ComEdAppFolder ComEd
        {
            get { return _comed; }
        }

        /// <summary>
        /// The NewFolder folder.
        /// </summary>
        [RepositoryFolder("3ccfc963-bc7c-42a5-8f76-2848b5c1ed55")]
        public virtual UploadFileRepositoryFolders.NewFolderFolder NewFolder
        {
            get { return _newfolder; }
        }

        /// <summary>
        /// The FileuploadPage folder.
        /// </summary>
        [RepositoryFolder("484c9437-e716-4775-9547-7ff646639903")]
        public virtual UploadFileRepositoryFolders.FileuploadPageAppFolder FileuploadPage
        {
            get { return _fileuploadpage; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.1")]
    public partial class UploadFileRepositoryFolders
    {
        /// <summary>
        /// The ComEdAppFolder folder.
        /// </summary>
        [RepositoryFolder("335b0c43-5f21-4662-8203-dc57658a3698")]
        public partial class ComEdAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _lnkbtnuploadnewboxInfo;

            /// <summary>
            /// Creates a new ComEd  folder.
            /// </summary>
            public ComEdAppFolder(RepoGenBaseFolder parentFolder) :
                    base("ComEd", "/dom[@domain=$CustomerPortalDom1 or @domain=$CustomerPortalDom2 or @visible='True']", parentFolder, 30000, null, false, "335b0c43-5f21-4662-8203-dc57658a3698", "")
            {
                _lnkbtnuploadnewboxInfo = new RepoItemInfo(this, "LnkBtnUploadNewBox", ".//a[#'lnkBtnUploadNewBox']", 30000, null, "3d15e65d-123e-45c0-ab6d-320590d3ff79");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("335b0c43-5f21-4662-8203-dc57658a3698")]
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
            [RepositoryItemInfo("335b0c43-5f21-4662-8203-dc57658a3698")]
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
            [RepositoryItem("3d15e65d-123e-45c0-ab6d-320590d3ff79")]
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
            [RepositoryItemInfo("3d15e65d-123e-45c0-ab6d-320590d3ff79")]
            public virtual RepoItemInfo LnkBtnUploadNewBoxInfo
            {
                get
                {
                    return _lnkbtnuploadnewboxInfo;
                }
            }
        }

        /// <summary>
        /// The NewFolderFolder folder.
        /// </summary>
        [RepositoryFolder("3ccfc963-bc7c-42a5-8f76-2848b5c1ed55")]
        public partial class NewFolderFolder : RepoGenBaseFolder
        {
            UploadFileRepositoryFolders.OpenAppFolder _open;

            /// <summary>
            /// Creates a new NewFolder  folder.
            /// </summary>
            public NewFolderFolder(RepoGenBaseFolder parentFolder) :
                    base("NewFolder", "", parentFolder, 0, null, false, "3ccfc963-bc7c-42a5-8f76-2848b5c1ed55", "")
            {
                _open = new UploadFileRepositoryFolders.OpenAppFolder(this);
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("3ccfc963-bc7c-42a5-8f76-2848b5c1ed55")]
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
            [RepositoryFolder("67de7357-995a-4a41-8660-1cc9a9ebcfa6")]
            public virtual UploadFileRepositoryFolders.OpenAppFolder Open
            {
                get { return _open; }
            }
        }

        /// <summary>
        /// The OpenAppFolder folder.
        /// </summary>
        [RepositoryFolder("67de7357-995a-4a41-8660-1cc9a9ebcfa6")]
        public partial class OpenAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _text1148Info;
            RepoItemInfo _buttonopenInfo;

            /// <summary>
            /// Creates a new Open  folder.
            /// </summary>
            public OpenAppFolder(RepoGenBaseFolder parentFolder) :
                    base("Open", "/form[@title='Open']", parentFolder, 30000, null, true, "67de7357-995a-4a41-8660-1cc9a9ebcfa6", "")
            {
                _text1148Info = new RepoItemInfo(this, "Text1148", "?/?/text[@controlid='1148']", 30000, null, "0827e0fe-9809-4037-84cd-2b1ab3a58625");
                _buttonopenInfo = new RepoItemInfo(this, "ButtonOpen", "button[@text='&Open']", 30000, null, "bfb66ee0-f900-48f8-9207-71b566097fdc");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("67de7357-995a-4a41-8660-1cc9a9ebcfa6")]
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
            [RepositoryItemInfo("67de7357-995a-4a41-8660-1cc9a9ebcfa6")]
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
            [RepositoryItem("0827e0fe-9809-4037-84cd-2b1ab3a58625")]
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
            [RepositoryItemInfo("0827e0fe-9809-4037-84cd-2b1ab3a58625")]
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
            [RepositoryItem("bfb66ee0-f900-48f8-9207-71b566097fdc")]
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
            [RepositoryItemInfo("bfb66ee0-f900-48f8-9207-71b566097fdc")]
            public virtual RepoItemInfo ButtonOpenInfo
            {
                get
                {
                    return _buttonopenInfo;
                }
            }
        }

        /// <summary>
        /// The FileuploadPageAppFolder folder.
        /// </summary>
        [RepositoryFolder("484c9437-e716-4775-9547-7ff646639903")]
        public partial class FileuploadPageAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _fileuploadlinkInfo;

            /// <summary>
            /// Creates a new FileuploadPage  folder.
            /// </summary>
            public FileuploadPageAppFolder(RepoGenBaseFolder parentFolder) :
                    base("FileuploadPage", "/dom[@domain='encodable.com']", parentFolder, 30000, null, false, "484c9437-e716-4775-9547-7ff646639903", "")
            {
                _fileuploadlinkInfo = new RepoItemInfo(this, "FIleuploadLInk", ".//input[#'uploadname1']", 30000, null, "0d70ef1c-803f-406f-b40e-0b1ac383eb81");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("484c9437-e716-4775-9547-7ff646639903")]
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
            [RepositoryItemInfo("484c9437-e716-4775-9547-7ff646639903")]
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
            [RepositoryItem("0d70ef1c-803f-406f-b40e-0b1ac383eb81")]
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
            [RepositoryItemInfo("0d70ef1c-803f-406f-b40e-0b1ac383eb81")]
            public virtual RepoItemInfo FIleuploadLInkInfo
            {
                get
                {
                    return _fileuploadlinkInfo;
                }
            }
        }

    }
#pragma warning restore 0436
}