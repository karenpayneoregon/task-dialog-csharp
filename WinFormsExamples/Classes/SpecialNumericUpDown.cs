﻿using System.ComponentModel;
#pragma warning disable CS8618

namespace WinFormsExamples.Classes;

/// <summary>
/// Custom <see cref="NumericUpDown"/> without spinner and a property to obtain value as an int
/// </summary>
public class SpecialNumericUpDown : NumericUpDown
{
    /// <inheritdoc />
    public SpecialNumericUpDown()
    {
        Controls[0].Hide();
        TextAlign = HorizontalAlignment.Right;
    }
    protected override void OnTextBoxResize(object? source, EventArgs e)
    {
        Controls[1].Width = Width - 4;
    }

    /// <summary>
    /// Return Value as an int
    /// </summary>
    [Browsable(false)] public int AsInteger => (int)Value;

    public delegate void TriggerDelegate();

    public event TriggerDelegate TriggerEvent;
    protected override void OnKeyDown(KeyEventArgs e)
    {
        if (e.KeyCode == (Keys.Return))
        {
            e.Handled = true;
            e.SuppressKeyPress = true;

            TriggerEvent?.Invoke();

            return;
        }

        base.OnKeyDown(e);
    }

}