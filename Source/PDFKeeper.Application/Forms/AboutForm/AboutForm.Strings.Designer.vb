﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
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
Friend Class AboutForm_Strings
    
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
                Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("PdfKeeper.AboutForm.Strings", GetType(AboutForm_Strings).Assembly)
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
    '''  Looks up a localized string similar to Components used by PDFKeeper and their respective licenses.
    '''
    '''Mini Icons (subset from collection)
    '''-------------------------------------
    '''Author: Mark James
    '''Website: http://www.famfamfam.com/lab/icons/mini/
    '''License: Available for free use for any purpose.
    '''
    '''Open Iconic (subset from collection)
    '''---------------------------------------
    '''Copyright (c) 2014 Waybury
    '''Website: https://github.com/iconic/open-iconic
    '''License: MIT (https://github.com/iconic/open-iconic/blob/master/ICON-LICENSE)
    '''
    '''ReadySET 0.9.3 [rest of string was truncated]&quot;;.
    '''</summary>
    Friend Shared ReadOnly Property Credits() As String
        Get
            Return ResourceManager.GetString("Credits", resourceCulture)
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
End Class