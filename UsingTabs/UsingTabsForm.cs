// Fig. 15.36: UsingTabsForm.cs
// Using TabControl to display various font settings.
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace UsingTabs
{
  // Form uses Tabs and RadioButtons to display various font settings
  public partial class UsingTabsForm : Form
  {
    private bool reversed = false;
    private bool upperCased = false;
    private bool lowerCased = false;
    private bool capitalized = true;
    // constructor
    public UsingTabsForm()
    {
      InitializeComponent();
      var styleBoxItems = new SelectOption[]
      {
        new SelectOption { Key = "Regular", Value = 0},
        new SelectOption { Key = "Bold", Value = 1},
        new SelectOption { Key = "Italic", Value = 2},
        new SelectOption { Key = "Strikeout", Value = 8},
        new SelectOption { Key = "Underline", Value = 4}
      };
      styleBox.Items.AddRange(styleBoxItems);
      styleBox.DisplayMember = "Key";
      styleBox.ValueMember = "Value";
      var families = FontFamily.Families;
      var familyBoxItems = new SelectOption[FontFamily.Families.Length];
      for (int i = 0; i < families.Length; i++)
      {
        familyBoxItems[i] = new SelectOption()
        {
          Key = families[i].Name,
          Value = families[i]
        };
      }
      familyBox.Items.AddRange(familyBoxItems);
      familyBox.DisplayMember = "Key";
      familyBox.ValueMember = "Value";
    } // end constructor

    // event handler for Black RadioButton
    private void blackRadioButton_CheckedChanged(
       object sender, EventArgs e)
    {
      displayLabel.ForeColor = Color.Black; // change color to black 
    } // end method blackRadioButton_CheckedChanged

    // event handler for Red RadioButton
    private void redRadioButton_CheckedChanged(
       object sender, EventArgs e)
    {
      displayLabel.ForeColor = Color.Red; // change color to red
    } // end method redRadioButton_CheckedChanged

    // event handler for Green RadioButton
    private void greenRadioButton_CheckedChanged(
       object sender, EventArgs e)
    {
      displayLabel.ForeColor = Color.Green; // change color to green
    } // end method greenRadioButton_CheckedChanged

    // event handler for Blue RadioButton
    private void blueRadioButton_CheckedChanged(
       object sender, EventArgs e)
    {
      displayLabel.ForeColor = Color.Blue; // change color to blue
    } // end method blueRadioButton_CheckedChanged

    private void yellowRadioButton_CheckedChanged(object sender, EventArgs e)
    {
      displayLabel.ForeColor = Color.Yellow;
    }

    private void orangeRadioButton_CheckedChanged(object sender, EventArgs e)
    {
      displayLabel.ForeColor = Color.Orange;
    }

    private void size8RadioButton_CheckedChanged(object sender, EventArgs e)
    {
      displayLabel.Font = new Font(displayLabel.Font.Name, 8, displayLabel.Font.Style);
    }

    // event handler for 12 point RadioButton
    private void size12RadioButton_CheckedChanged(
         object sender, EventArgs e)
    {
      // change font size to 12
      displayLabel.Font = new Font(displayLabel.Font.Name, 12, displayLabel.Font.Style);
    } // end method size12RadioButton_CheckedChanged

    // event handler for 16 point RadioButton
    private void size16RadioButton_CheckedChanged(
       object sender, EventArgs e)
    {
      // change font size to 16
      displayLabel.Font = new Font(displayLabel.Font.Name, 16, displayLabel.Font.Style);
    } // end method size16RadioButton_CheckedChanged

    // event handler for 20 point RadioButton
    private void size20RadioButton_CheckedChanged(
       object sender, EventArgs e)
    {
      // change font size to 20
      displayLabel.Font = new Font(displayLabel.Font.Name, 20, displayLabel.Font.Style);
    } // end method size20RadioButton_CheckedChanged

    private void size24RadioButton_CheckedChanged(object sender, EventArgs e)
    {
      displayLabel.Font = new Font(displayLabel.Font.Name, 24, displayLabel.Font.Style);
    }

    private void size28RadioButton_CheckedChanged(object sender, EventArgs e)
    {
      displayLabel.Font = new Font(displayLabel.Font.Name, 28, displayLabel.Font.Style);
    }

    // event handler for  Hello! RadioButton
    private void helloRadioButton_CheckedChanged(
       object sender, EventArgs e)
    {
      displayLabel.Text = "Hello!"; // change text to Hello!
      lengthValueLabel.Text = displayLabel.Text.Length.ToString();
    } // end method helloRadioButton_CheckedChanged

    // event handler for Goodbye! RadioButton
    private void goodbyeRadioButton_CheckedChanged(
       object sender, EventArgs e)
    {
      displayLabel.Text = "Goodbye!"; // change text to Goodbye!
      lengthValueLabel.Text = displayLabel.Text.Length.ToString();
    } // end method goodbyeRadioButton_CheckedChanged

    private void stopRadioButton_CheckedChanged(object sender, EventArgs e)
    {
      displayLabel.Text = "Stop!";
      lengthValueLabel.Text = displayLabel.Text.Length.ToString();
    }

    private void waitRadioButton_CheckedChanged(object sender, EventArgs e)
    {
      displayLabel.Text = "Wait!";
      lengthValueLabel.Text = displayLabel.Text.Length.ToString();
    }

    private void surpriseRadioButton_CheckedChanged(object sender, EventArgs e)
    {
      displayLabel.Text = "Surprise!";
      lengthValueLabel.Text = displayLabel.Text.Length.ToString();
    }

    private void watchOutRadioButton_CheckedChanged(object sender, EventArgs e)
    {
      displayLabel.Text = "Watch Out!";
      lengthValueLabel.Text = displayLabel.Text.Length.ToString();
    }

    private void fontStyleChanged(object sender, EventArgs e)
    {
      var fontStyleBox = (ComboBox)sender;
      var chosenValue = ((SelectOption)fontStyleBox.SelectedItem).Value;
      displayLabel.Font = new Font(displayLabel.Font.FontFamily, displayLabel.Font.Size, (FontStyle)(chosenValue));
    }

    private void fontFamilyChanged(object sender, EventArgs e)
    {
      var fontFamilyBox = (ComboBox)sender;
      var chosenValue = ((SelectOption)fontFamilyBox.SelectedItem).Value;
      displayLabel.Font = new Font((FontFamily)(chosenValue), displayLabel.Font.Size, displayLabel.Font.Style);
    }

    private void upperCaseChanged(object sender, EventArgs e)
    {
      var radioButton = (RadioButton)sender;
      var isChecked = radioButton.Checked;
      lowerCased = false;
      capitalized = false;
      displayLabel.Text = displayLabel.Text.ToUpper();
    }

    private void reverseChanged(object sender, EventArgs e)
    {
      var checkBox = (CheckBox)sender;
      reversed = checkBox.Checked;
      var chars = displayLabel.Text.ToCharArray();
      for (int i = 0, j = chars.Length - 1; i < j; i++, j--)
      {
        chars[i] = displayLabel.Text[j];
        chars[j] = displayLabel.Text[i];
      }
      displayLabel.Text = new string(chars);
    }

    private void lowerCaseChanged(object sender, EventArgs e)
    {
      var radioButton = (RadioButton)sender;
      var isChecked = radioButton.Checked;
      upperCased = false;
      capitalized = false;
      displayLabel.Text = displayLabel.Text.ToLower();
    }

    private void capitalizedChanged(object sender, EventArgs e)
    {
      var radioButton = (RadioButton)sender;
      var isChecked = radioButton.Checked;
      upperCased = !isChecked;
      lowerCased = !isChecked;
      displayLabel.Text = displayLabel.Text.ToLower();
      if (reversed) {
        var first = displayLabel.Text[displayLabel.Text.Length - 1].ToString().ToUpper();
        var remaining = displayLabel.Text.Substring(0, displayLabel.Text.Length - 1);
        displayLabel.Text = remaining + first;
      }
      else
      {
        var first = displayLabel.Text[0].ToString().ToUpper();
        var remaining = displayLabel.Text.Substring(1, displayLabel.Text.Length - 1);
        displayLabel.Text = first + remaining;
      }
    }
  } // end class UsingTabsForm

  class SelectOption
  {
    public string Key { get; set; }
    public object Value { get; set; }
  }
} // end namespace UsingTabs

/**************************************************************************
 * (C) Copyright 1992-2011 by Deitel & Associates, Inc. and               *
 * Pearson Education, Inc. All Rights Reserved.                           *
 *                                                                        *
 * DISCLAIMER: The authors and publisher of this book have used their     *
 * best efforts in preparing the book. These efforts include the          *
 * development, research, and testing of the theories and programs        *
 * to determine their effectiveness. The authors and publisher make       *
 * no warranty of any kind, expressed or implied, with regard to these    *
 * programs or to the documentation contained in these books. The authors *
 * and publisher shall not be liable in any event for incidental or       *
 * consequential damages in connection with, or arising out of, the       *
 * furnishing, performance, or use of these programs.                     *
 *************************************************************************/
