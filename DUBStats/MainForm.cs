using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Novacode;

namespace DUBStats
{
    public partial class MainForm : Form
    {
        private readonly string _dubHeaderPattern;
        private readonly string _dubNumberPattern;
        private readonly string _characterHeaderPattern;
        private readonly string _characterPattern;
        private string _inputFile;
        private Dictionary<string, Dictionary<int, int>> _parseResult;

        public MainForm()
        {
            // ([0-9])+         Loop number
            // ([_])+           Group of underlines
            // (DUB){1}         DUB
            // \s*              Zero or more whitespaces
            // \[               Open square bracket
            // ([0-9]|[:])*     A group of digits and semicolons, 0 or more times
            // \]               Close square bracket
            // (.)*             Qualquer character except \n, 0 or more times
            //_dubHeaderPattern = @"^([0-9])+([_])+(DUB){1}\s+\[([0-9]{2}[:]){3}[0-9]{2}\]([\s|\t])*$";
            _dubHeaderPattern = @"^([0-9])+([_])+(DUB){1}\s*\[([0-9]|[:])*\](.)*$";
            _dubNumberPattern = @"([0-9])+";
            // (\[)?            Open square bracket one or zero times
            // ([0-9]|[:])*     A group of digits and semicolons, 0 or more times
            // (\])?            Close square bracket one or zero times
            // ([\s|\t])+       A group of whitespaces or tabs 1 or more times
            // \w               A word character
            // (.)*             Qualquer character except \n, 0 or more times
            _characterHeaderPattern = @"^(\[)?([0-9]|[:])*(\])?([\s|\t])+\w(.)*$";
            _characterPattern = @"([\s|\t])+(.)*";
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog
            {
                Title = @"Select File",
                Filter = @"Word files|*.doc;*.docx|All Files|*.*"
            };

            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                _inputFile = openFileDialog.FileName;
                fileLocationTextBox.Text = _inputFile;
                resultTextBox.Text = String.Empty;
                ParseInputFile(_inputFile);
            }
        }

        private void ParseInputFile(string filePath)
        {
            _parseResult = new Dictionary<string, Dictionary<int, int>>();
            var currentLoop = 0;
            var loopsList = new List<int>();
            var count = 0;
            try
            {
                using (var document = DocX.Load(filePath))
                {
                    foreach (var paragraph in document.Paragraphs)
                    {
                        if (System.Text.RegularExpressions.Regex.IsMatch(paragraph.Text, _dubHeaderPattern))
                        {
                            count++;
                            var match = System.Text.RegularExpressions.Regex.Match(paragraph.Text, _dubNumberPattern);
                            currentLoop = Convert.ToInt32(match.Value);
                            loopsList.Add(currentLoop);
                        }
                        else if (System.Text.RegularExpressions.Regex.IsMatch(paragraph.Text, _characterHeaderPattern))
                        {
                            var match = System.Text.RegularExpressions.Regex.Match(paragraph.Text, _characterPattern);
                            var character = match.Value.Replace("]", "");
                            character = character.Trim();
                            if (!_parseResult.ContainsKey(character))
                            {
                                _parseResult.Add(character, new Dictionary<int, int> {{currentLoop, 1}});
                            }
                            else
                            {
                                if (!_parseResult[character].ContainsKey(currentLoop))
                                {
                                    _parseResult[character].Add(currentLoop, 1);
                                }
                                else
                                {
                                    _parseResult[character][currentLoop]++;
                                }
                            }
                        }
                    }
                    MessageBox.Show(@"There are " + count + @" dub headers.");
                }
            }
            catch (System.IO.FileFormatException ex)
            {
                MessageBox.Show(this,
                    @"The Word document is not in the right format. Please convert it to a .DOCX format for Word 2007 or more recent.",
                    @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (System.IO.IOException ex)
            {
                MessageBox.Show(this,
                    @"The document cannot be parsed because it is being used by another process. Please make sure that the document is closed in your machine.",
                    @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this,
                    ex.Message + @" Contact the technical support.",
                    @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
        }

        private void getStatsButton_Click(object sender, EventArgs e)
        {
            var text = new StringBuilder();
            foreach (var outerKeyValuePair in _parseResult)
            {
                var count = 0;
                text.AppendLine(outerKeyValuePair.Key + ": " + _parseResult[outerKeyValuePair.Key].Keys.Count + " loops.");
                foreach (var innerKeyValuePair in _parseResult[outerKeyValuePair.Key])
                {
                    if (count == _parseResult[outerKeyValuePair.Key].Keys.Count)
                    {
                        text.AppendLine(innerKeyValuePair.Key + ".");
                    }
                    else
                    {
                        text.Append(innerKeyValuePair.Key + ", ");
                    }
                    count++;
                }
                text.AppendLine();
                text.AppendLine();
            }
            resultTextBox.Text = text.ToString(0, text.Length);
            PdfCreator.CreatePdf(text.ToString(0, text.Length));
        }
    }
}