﻿' *****************************************************************************
' * PDFKeeper -- Open Source PDF Document Management
' * Copyright (C) 2009-2023 Robert F. Frasca
' *
' * This file is part of PDFKeeper.
' *
' * PDFKeeper is free software: you can redistribute it and/or modify it
' * under the terms of the GNU General Public License as published by the
' * Free Software Foundation, either version 3 of the License, or (at your
' * option) any later version.
' *
' * PDFKeeper is distributed in the hope that it will be useful, but WITHOUT
' * ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or
' * FITNESS FOR A PARTICULAR PURPOSE. See the GNU General Public License for
' * more details.
' *
' * You should have received a copy of the GNU General Public License along
' * with PDFKeeper. If not, see <https://www.gnu.org/licenses/>.
' *****************************************************************************

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SubjectUserControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SubjectUserControl))
        Me.Label = New System.Windows.Forms.Label()
        Me.SubjectComboBox = New PDFKeeper.Presentation.CustomComboBox(Me.components)
        Me.SuspendLayout()
        '
        'Label
        '
        resources.ApplyResources(Me.Label, "Label")
        Me.Label.Name = "Label"
        '
        'SubjectComboBox
        '
        Me.SubjectComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.SubjectComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        resources.ApplyResources(Me.SubjectComboBox, "SubjectComboBox")
        Me.SubjectComboBox.FormattingEnabled = True
        Me.SubjectComboBox.Name = "SubjectComboBox"
        '
        'SubjectUserControl
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SubjectComboBox)
        Me.Controls.Add(Me.Label)
        Me.Name = "SubjectUserControl"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label As Label
    Friend WithEvents SubjectComboBox As CustomComboBox
End Class