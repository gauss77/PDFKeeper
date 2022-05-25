﻿'******************************************************************************
'* PDFKeeper -- Open Source PDF Document Management
'* Copyright (C) 2009-2022 Robert F. Frasca
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
Imports PDFKeeper.Domain

Public Interface ITaxYearListService
    ''' <summary>
    ''' Lists tax years in the repository by group.
    ''' </summary>
    ''' <returns>DataTable object</returns>
    Function ListTaxYears() As DataTable

    ''' <summary>
    ''' Lists tax years in the repository by group.
    ''' </summary>
    ''' <param name="filter">TaxYearFilterModel object</param>
    ''' <returns>DataTable object</returns>
    Function ListTaxYears(ByVal filter As TaxYearFilterModel) As DataTable

    ''' <summary>
    ''' Lists a range of tax years starting with a blank item followed by a range of years that includes the last
    ''' 10 years and 1 year into the future.
    ''' </summary>
    ''' <returns>DataTable object sorted in reverse order.</returns>
    Function ListRangeOfTaxYears() As DataTable
End Interface