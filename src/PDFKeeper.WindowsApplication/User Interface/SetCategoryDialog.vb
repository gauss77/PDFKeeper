﻿'******************************************************************************
'* PDFKeeper -- Open Source PDF Document Management System
'* Copyright (C) 2009-2019 Robert F. Frasca
'*
'* This file is part of PDFKeeper.
'*
'* PDFKeeper is free software: you can redistribute it and/or modify
'* it under the terms of the GNU General Public License as published by
'* the Free Software Foundation, either version 3 of the License, or
'* (at your option) any later version.
'*
'* PDFKeeper is distributed in the hope that it will be useful,
'* but WITHOUT ANY WARRANTY; without even the implied warranty of
'* MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
'* GNU General Public License for more details.
'*
'* You should have received a copy of the GNU General Public License
'* along with PDFKeeper.  If not, see <http://www.gnu.org/licenses/>.
'******************************************************************************
Imports System.Windows.Forms

Public Class SetCategoryDialog
    Implements ICommonView
    Private presenter As CommonViewPresenter
    Private help As New HelpFile

    Public Sub New()
        InitializeComponent()
        presenter = New CommonViewPresenter(Me)
        HelpProvider.HelpNamespace = help.Name
    End Sub

#Region "Interface Members"
    Public Property Authors As DataTable Implements ICommonView.Authors
        Get
            Return Nothing
        End Get
        Set(value As DataTable)
            Throw New NotImplementedException
        End Set
    End Property

    Public Property Author As String Implements ICommonView.Author
        Get
            Return Nothing
        End Get
        Set(value As String)
            Throw New NotImplementedException
        End Set
    End Property

    Public Property Subjects As DataTable Implements ICommonView.Subjects
        Get
            Return Nothing
        End Get
        Set(value As DataTable)
            Throw New NotImplementedException
        End Set
    End Property

    Public Property Subject As String Implements ICommonView.Subject
        Get
            Return Nothing
        End Get
        Set(value As String)
            Throw New NotImplementedException
        End Set
    End Property

    Public Property AuthorsPaired As DataTable Implements ICommonView.AuthorsPaired
        Get
            Return Nothing
        End Get
        Set(value As DataTable)
            Throw New NotImplementedException
        End Set
    End Property

    Public Property AuthorPaired As String Implements ICommonView.AuthorPaired
        Get
            Return Nothing
        End Get
        Set(value As String)
            Throw New NotImplementedException
        End Set
    End Property

    Public Property SubjectsPaired As DataTable Implements ICommonView.SubjectsPaired
        Get
            Return Nothing
        End Get
        Set(value As DataTable)
            Throw New NotImplementedException
        End Set
    End Property

    Public Property SubjectPaired As String Implements ICommonView.SubjectPaired
        Get
            Return Nothing
        End Get
        Set(value As String)
            Throw New NotImplementedException
        End Set
    End Property

    Public Property Categories As DataTable Implements ICommonView.Categories
        Get
            Return CategoryComboBox.DataSource
        End Get
        Set(value As DataTable)
            CategoryComboBox.DataSource = value
            CategoryComboBox.DisplayMember = "doc_category"
        End Set
    End Property

    Public Property Category As String Implements ICommonView.Category
        Get
            Return CategoryComboBox.Text
        End Get
        Set(value As String)
            CategoryComboBox.Text = value
        End Set
    End Property

    Public ReadOnly Property ActiveElement As String Implements ICommonView.ActiveElement
        Get
            Return Me.ActiveControl.Name
        End Get
    End Property

    Public Sub OnLongRunningOperationStarted() Implements ICommonView.OnLongRunningOperationStarted
        Me.Cursor = Cursors.WaitCursor
    End Sub

    Public Sub OnLongRunningOperationFinished() Implements ICommonView.OnLongRunningOperationFinished
        Me.Cursor = Cursors.Default
    End Sub
#End Region

    Private Sub CategoryComboBox_Enter(sender As Object, e As EventArgs) Handles CategoryComboBox.Enter
        presenter.GetColumnItemsByGroup()
    End Sub

    Private Sub CategoryComboBox_TextChanged(sender As Object, e As EventArgs) Handles CategoryComboBox.TextChanged, CategoryComboBox.TextUpdate
        presenter.ActiveElementTextTrimStart()
    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        presenter.AllElementsTextTrimEnd()
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
End Class
