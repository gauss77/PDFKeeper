﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.34209
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System


'This class was auto-generated by the StronglyTypedResourceBuilder
'class via a tool like ResGen or Visual Studio.
'To add or remove a member, edit your .ResX file then rerun ResGen
'with the /str option, or rebuild your VS project.
'''<summary>
'''  A strongly-typed resource class, for looking up localized strings, etc.
'''</summary>
<Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0"),  _
 Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
 Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
Friend Class Strings
	
	Private Shared resourceMan As Global.System.Resources.ResourceManager
	
	Private Shared resourceCulture As Global.System.Globalization.CultureInfo
	
	<Global.System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")>  _
	Friend Sub New()
		MyBase.New
	End Sub
	
	'''<summary>
	'''  Returns the cached ResourceManager instance used by this class.
	'''</summary>
	<Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
	Friend Shared ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
		Get
			If Object.ReferenceEquals(resourceMan, Nothing) Then
				Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("PdfKeeper.Strings", GetType(Strings).Assembly)
				resourceMan = temp
			End If
			Return resourceMan
		End Get
	End Property
	
	'''<summary>
	'''  Overrides the current thread's CurrentUICulture property for all
	'''  resource lookups using this strongly typed resource class.
	'''</summary>
	<Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
	Friend Shared Property Culture() As Global.System.Globalization.CultureInfo
		Get
			Return resourceCulture
		End Get
		Set
			resourceCulture = value
		End Set
	End Property
	
	'''<summary>
	'''  Looks up a localized string similar to {0} cannot be deleted because it contains PDF documents..
	'''</summary>
	Friend Shared ReadOnly Property CannotDeleteFolder() As String
		Get
			Return ResourceManager.GetString("CannotDeleteFolder", resourceCulture)
		End Get
	End Property
	
	'''<summary>
	'''  Looks up a localized string similar to Components used by PDFKeeper and their respective licenses.
	'''
	'''Mini Icons (subset from collection)
	'''-------------------------------------
	'''Author: Mark James
	'''Website: http://www.famfamfam.com/lab/icons/mini/
	'''License: Available for free use for any purpose.
	'''
	'''Snowish Icons (subset from collection)
	'''-----------------------------------------
	'''Author: Saki (Alexandre Moore)
	'''Website: http://www.iconarchive.com/show/snowish-icons-by-saki.html
	'''License: GPLv2 (http://www.iconarchive.com/icons/saki/snowish/GPL. [rest of string was truncated]&quot;;.
	'''</summary>
	Friend Shared ReadOnly Property Credits() As String
		Get
			Return ResourceManager.GetString("Credits", resourceCulture)
		End Get
	End Property
	
	'''<summary>
	'''  Looks up a localized string similar to Delete {0}?.
	'''</summary>
	Friend Shared ReadOnly Property DeleteFolderQuestion() As String
		Get
			Return ResourceManager.GetString("DeleteFolderQuestion", resourceCulture)
		End Get
	End Property
	
	'''<summary>
	'''  Looks up a localized string similar to Direct Upload.
	'''</summary>
	Friend Shared ReadOnly Property DirectUpload() As String
		Get
			Return ResourceManager.GetString("DirectUpload", resourceCulture)
		End Get
	End Property
	
	'''<summary>
	'''  Looks up a localized string similar to Database User name.
	'''</summary>
	Friend Shared ReadOnly Property DirectUploadConfigAuthorDatabaseUserName() As String
		Get
			Return ResourceManager.GetString("DirectUploadConfigAuthorDatabaseUserName", resourceCulture)
		End Get
	End Property
	
	'''<summary>
	'''  Looks up a localized string similar to Windows User name.
	'''</summary>
	Friend Shared ReadOnly Property DirectUploadConfigAuthorWindowsUserName() As String
		Get
			Return ResourceManager.GetString("DirectUploadConfigAuthorWindowsUserName", resourceCulture)
		End Get
	End Property
	
	'''<summary>
	'''  Looks up a localized string similar to Scanned Document.
	'''</summary>
	Friend Shared ReadOnly Property DirectUploadConfigSubjectScannedDocument() As String
		Get
			Return ResourceManager.GetString("DirectUploadConfigSubjectScannedDocument", resourceCulture)
		End Get
	End Property
	
	'''<summary>
	'''  Looks up a localized string similar to Date.
	'''</summary>
	Friend Shared ReadOnly Property DirectUploadConfigTitleDate() As String
		Get
			Return ResourceManager.GetString("DirectUploadConfigTitleDate", resourceCulture)
		End Get
	End Property
	
	'''<summary>
	'''  Looks up a localized string similar to Date and Time.
	'''</summary>
	Friend Shared ReadOnly Property DirectUploadConfigTitleDateTime() As String
		Get
			Return ResourceManager.GetString("DirectUploadConfigTitleDateTime", resourceCulture)
		End Get
	End Property
	
	'''<summary>
	'''  Looks up a localized string similar to File name.
	'''</summary>
	Friend Shared ReadOnly Property DirectUploadConfigTitleFileName() As String
		Get
			Return ResourceManager.GetString("DirectUploadConfigTitleFileName", resourceCulture)
		End Get
	End Property
	
	'''<summary>
	'''  Looks up a localized string similar to Are you sure you want to discard all modifications?.
	'''</summary>
	Friend Shared ReadOnly Property DiscardAllModificationsPrompt() As String
		Get
			Return ResourceManager.GetString("DiscardAllModificationsPrompt", resourceCulture)
		End Get
	End Property
	
	'''<summary>
	'''  Looks up a localized string similar to Document Capture.
	'''</summary>
	Friend Shared ReadOnly Property DocumentCapture() As String
		Get
			Return ResourceManager.GetString("DocumentCapture", resourceCulture)
		End Get
	End Property
	
	'''<summary>
	'''  Looks up a localized string similar to File name contains invalid characters..
	'''</summary>
	Friend Shared ReadOnly Property FileNameContainsInvalidChars() As String
		Get
			Return ResourceManager.GetString("FileNameContainsInvalidChars", resourceCulture)
		End Get
	End Property
	
	'''<summary>
	'''  Looks up a localized string similar to {0} is already configured..
	'''</summary>
	Friend Shared ReadOnly Property FolderAlreadyConfigured() As String
		Get
			Return ResourceManager.GetString("FolderAlreadyConfigured", resourceCulture)
		End Get
	End Property
	
	'''<summary>
	'''  Looks up a localized string similar to Folder name contains invalid characters..
	'''</summary>
	Friend Shared ReadOnly Property FolderNameContainsInvalidChars() As String
		Get
			Return ResourceManager.GetString("FolderNameContainsInvalidChars", resourceCulture)
		End Get
	End Property
	
	'''<summary>
	'''  Looks up a localized string similar to Incorrect OWNER password.  If you do not know the password and have the legal right to remove the password, you can find plenty of information on the internet to assist you..
	'''</summary>
	Friend Shared ReadOnly Property IncorrectOwnerPassword() As String
		Get
			Return ResourceManager.GetString("IncorrectOwnerPassword", resourceCulture)
		End Get
	End Property
	
	'''<summary>
	'''  Looks up a localized string similar to GNU GENERAL PUBLIC LICENSE
	'''Version 3, 29 June 2007
	'''
	'''Copyright © 2007 Free Software Foundation, Inc. &lt;http://fsf.org/&gt;
	'''
	'''Everyone is permitted to copy and distribute verbatim copies of this license document, but changing it is not allowed.
	'''
	'''Preamble
	'''The GNU General Public License is a free, copyleft license for software and other kinds of works.
	'''
	'''The licenses for most software and other practical works are designed to take away your freedom to share and change the works. By contrast, the GNU General [rest of string was truncated]&quot;;.
	'''</summary>
	Friend Shared ReadOnly Property License() As String
		Get
			Return ResourceManager.GetString("License", resourceCulture)
		End Get
	End Property
	
	'''<summary>
	'''  Looks up a localized string similar to Error.
	'''</summary>
	Friend Shared ReadOnly Property MessageBoxTitleError() As String
		Get
			Return ResourceManager.GetString("MessageBoxTitleError", resourceCulture)
		End Get
	End Property
	
	'''<summary>
	'''  Looks up a localized string similar to Information.
	'''</summary>
	Friend Shared ReadOnly Property MessageBoxTitleInformation() As String
		Get
			Return ResourceManager.GetString("MessageBoxTitleInformation", resourceCulture)
		End Get
	End Property
	
	'''<summary>
	'''  Looks up a localized string similar to Question.
	'''</summary>
	Friend Shared ReadOnly Property MessageBoxTitleQuestion() As String
		Get
			Return ResourceManager.GetString("MessageBoxTitleQuestion", resourceCulture)
		End Get
	End Property
	
	'''<summary>
	'''  Looks up a localized string similar to {0} is password protected which is not supported by Direct Upload.  If you have the legal right to remove the password, you can find plenty of information on the internet to assist you..
	'''</summary>
	Friend Shared ReadOnly Property PdfContainsPassword() As String
		Get
			Return ResourceManager.GetString("PdfContainsPassword", resourceCulture)
		End Get
	End Property
	
	'''<summary>
	'''  Looks up a localized string similar to {0} contains a USER password which is not supported by PDFKeeper.  If you have the legal right to remove the password, you can find plenty of information on the internet to assist you..
	'''</summary>
	Friend Shared ReadOnly Property PdfContainsUserPassword() As String
		Get
			Return ResourceManager.GetString("PdfContainsUserPassword", resourceCulture)
		End Get
	End Property
	
	'''<summary>
	'''  Looks up a localized string similar to The Title, Author, and Subject properties cannot be blank..
	'''</summary>
	Friend Shared ReadOnly Property PdfPropertiesBlank() As String
		Get
			Return ResourceManager.GetString("PdfPropertiesBlank", resourceCulture)
		End Get
	End Property
End Class
