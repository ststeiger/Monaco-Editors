﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Dieser Code wurde von einem Tool generiert.
'
'     Änderungen an dieser Datei können fehlerhaftes Verhalten verursachen und gehen verloren, wenn
'     der Code neu generiert wird.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace My.Resources

    'Diese Klasse wurde von der StronglyTypedResourceBuilder-Klasse
    'mithilfe eines Tools wie ResGen oder Visual Studio automatisch generiert.
    'Bearbeiten Sie zum Hinzufügen oder Entfernen eines Members die .ResX-Datei, und führen Sie dann ResGen
    'mit der Option "/str" erneut aus, oder erstellen Sie das VS-Projekt neu.
    '<summary>
    '  Eine Ressourcenklasse mit starker Typisierung zum Suchen von lokalisierten Zeichenfolgen usw.
    '</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0"), _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(), _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()> _
    Friend Module Resources

        Private resourceMan As Global.System.Resources.ResourceManager

        Private resourceCulture As Global.System.Globalization.CultureInfo

        '<summary>
        '  Gibt die von dieser Klasse verwendete zwischengespeicherte ResourceManager-Instanz zurück.
        '</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("Monaco_Editors.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property

        '<summary>
        '  Überschreibt die CurrentUICulture-Eigenschaft des aktuellen Threads für alle
        '  Ressourcenlookups, die diese stark typisierte Ressourcenklasse verwenden.
        '</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set(ByVal value As Global.System.Globalization.CultureInfo)
                resourceCulture = value
            End Set
        End Property
    End Module
End Namespace
