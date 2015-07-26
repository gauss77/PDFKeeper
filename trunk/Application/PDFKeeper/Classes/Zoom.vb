﻿'******************************************************************************
'*
'* PDFKeeper -- PDF Document Capture, Storage, and Search
'* Copyright (C) 2009-2015 Robert F. Frasca
'*
'* This file is part of PDFKeeper.
'*
'* PDFKeeper is free software: you can redistribute it and/or modify it under
'* the terms of the GNU General Public License as published by the Free
'* Software Foundation, either version 3 of the License, or (at your option)
'* any later version.
'*
'* PDFKeeper is distributed in the hope that it will be useful, but WITHOUT
'* ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or
'* FITNESS FOR A PARTICULAR PURPOSE.  See the GNU General Public License for
'* more details.
'*
'* You should have received a copy of the GNU General Public License along
'* with PDFKeeper.  If not, see <http://www.gnu.org/licenses/>.
'*
'******************************************************************************

Public NotInheritable Class Zoom
	Shared m_Percentage As Int32
	
	''' <summary>
	''' Private constructor required for FxCop compliance (CA1053).
	''' </summary>
	Private Sub New()
	End Sub
	
	''' <summary>
	''' Get and set zoom percentage.
	'''
	''' Note: Property can not be set to a value less than 100%.
	''' </summary>
	Shared Property Percentage() As Int32
		Get
			If m_Percentage = Nothing Then
				m_Percentage = 100
			End If
			Return m_Percentage
		End Get
		Set(ByVal value As Int32)
			m_Percentage = value
			If m_Percentage < 100 Then
				m_Percentage = 100
			End If
		End Set
	End Property
	
	''' <summary>
	''' Increase zoom percentage by 25%.
	''' </summary>
	Public Shared Sub IncreasePercentage
		Percentage += 25
	End Sub
	
	''' <summary>
	''' Decrease zoom percentage by 25%.
	''' </summary>
	Public Shared Sub DecreasePercentage
		Percentage -= 25
	End Sub
	
	''' <summary>
	''' Reset zoom percentage to 100%.
	''' </summary>
	Public Shared Sub ResetPercentage
		Percentage = 100
	End Sub
End Class
