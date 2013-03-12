/***************************************************************************

Copyright (c) Microsoft Corporation. All rights reserved.
This code is licensed under the Visual Studio SDK license terms.
THIS CODE IS PROVIDED *AS IS* WITHOUT WARRANTY OF
ANY KIND, EITHER EXPRESS OR IMPLIED, INCLUDING ANY
IMPLIED WARRANTIES OF FITNESS FOR A PARTICULAR
PURPOSE, MERCHANTABILITY, OR NON-INFRINGEMENT.

***************************************************************************/

using System;

namespace Nhn.Git.SourceControl.Provider
{
	/// <summary>
	/// This class is used to expose the list of the IDs of the commands implemented
	/// by the client package. This list of IDs must match the set of IDs defined inside the
	/// VSCT file.
	/// </summary>
	public static class CommandId
	{
		// Define the list a set of public static members.

		// Define the list of menus (these include toolbars)
        public const int imnuToolWindowToolbarMenu      = 0x201;

        public const int icmdAddToSourceControl			= 0x100;
        public const int icmdCheckout					= 0x101;
        public const int icmdCheckin                    = 0x102;
        public const int icmdToolWindowToolbarCommand   = 0x104;
        public const int icmdUseSccOffline              = 0x105;


        // Define the list of icons (use decimal numbers here, to match the resource IDs)
        public const int iiconProductIcon               = 400;

        // Define the list of bitmaps (use decimal numbers here, to match the resource IDs)
        public const int ibmpToolbarMenusImages         = 500;
        public const int ibmpToolWindowsImages          = 501;

        // Glyph indexes in the bitmap used for tolwindows (ibmpToolWindowsImages)
        public const int iconSccProviderToolWindow      = 0;



        //Ngit Menu Exe Command
        public const int cmdidNhnGitCreate      = 0x550;
        public const int cmdidNhnGitClone       = 0x551;

        public const int cmdidNhnGitStage       = 0x552;
        public const int cmdidNhnGitUnStage     = 0x553;
        public const int cmdidNhnGitCommit      = 0x554;
        public const int cmdidNhnGitDiscard     = 0x555;
        public const int cmdidNhnGitDelete      = 0x556;

        public const int cmdidNhnGitRepo        = 0x557;
        public const int cmdidNhnGitRemote        = 0x558;
        public const int cmdidNhnGitLocal        = 0x559;

        public const int cmdidNhnGitStash       = 0x560;

        public const int cmdidNhnGitAdvanced    = 0x563;
        public const int cmdidNhnGitBlame         = 0x564;
        public const int cmdidNhnGitIgnore      = 0x565;
        public const int cmdidNhnProperyWnd     = 0x566;
	}
}
