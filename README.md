# PC Troubleshooter
Small program made by Gashgai for a school assignment.
## What is this?
A PC troubleshooter with 5 options to help you identify and solve common computer problems. It also includes a history form where you can view your previous troubleshooting sessions.

---

<img width="655" height="431" alt="image" src="https://github.com/user-attachments/assets/f91bdd9e-ddde-49dc-b005-371d32a4056f" />
<img width="718" height="475" alt="image" src="https://github.com/user-attachments/assets/83219d57-1868-47d3-b25c-680c609d4dda" />

## Architecture

<img width="578" height="696" alt="pctroubleshooter" src="https://github.com/user-attachments/assets/e669a1ca-b457-4053-91f6-cabbc9f4ba51" />
### Code infrastructure
ShowResult() is used to display the detected problem and its suggested solution. It hides the question panel, shows the answer panel, updates the labels, and saves the problem to the history.
```
        private void ShowResult(string problem, string solution) //Jokaisen ratkaisun loppuvaihe
        {
            panelQuestion.Visible = false;
            panelAnswer.Visible = true;
            lblProblem.Text = "Mahdollinen ongelma: " + problem;
            lblSolution.Text = "Ratkaisuehdotus: " + solution;

            Savetohistory(problem);
        }
```
## Future Ideas
- Better looking UI.
- Searchable problems.
