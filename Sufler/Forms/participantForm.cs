using Sufler.CustomControl;
using Sufler.Models;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Sufler.Forms
{
    public partial class participantForm : ParentForm
    {
        private project _project;
        private user _user;

        public participantForm()
        {
            InitializeComponent();
        }

        public participantForm(project project, user user)
        {
            InitializeComponent();
            _project = project;
            _user = user;
        }

        private void participantForm_Load(object sender, EventArgs e)
        {
            roundedButtonParticipants_Click(sender, e);
        }

        private void roundedButtonParticipants_Click(object sender, EventArgs e)
        {
            flowLayoutPanelResp.Visible = false;
            flowLayoutPanelParsipants.Visible = true;
            LoadParticipants();
        }

        private void roundedButtonResponse_Click(object sender, EventArgs e)
        {
            flowLayoutPanelParsipants.Visible = false;
            flowLayoutPanelResp.Visible = true;
            LoadResponses();
        }

        private void LoadParticipants()
        {
            flowLayoutPanelParsipants.Controls.Clear();

            using (var db = new SuflerDB())
            {
                var participants = db.participants
                    .Where(p => p.id_project == _project.project_id)
                    .ToList();

                if (participants.Count == 0)
                {
                    var emptyLabel = new Label()
                    {
                        Text = "Нет участников проекта.",
                        AutoSize = true,
                        ForeColor = Color.Gray,
                        Font = new Font("Segoe UI", 10, FontStyle.Italic),
                        Margin = new Padding(10)
                    };
                    flowLayoutPanelParsipants.Controls.Add(emptyLabel);
                    return;
                }

                foreach (var participant in participants)
                {
                    var user = db.users.FirstOrDefault(u => u.user_id == participant.id_user);
                    if (user != null)
                    {
                        var control = new UserParticipantItem(participant, _user.user_id);
                        control.Width = flowLayoutPanelParsipants.Width - 25;
                        control.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
                        flowLayoutPanelParsipants.Controls.Add(control);
                    }
                }
            }
        }

        private void LoadResponses()
        {
            flowLayoutPanelResp.Controls.Clear();

            using (var db = new SuflerDB())
            {
                var responses = db.responses
                    .Where(r => r.id_project == _project.project_id)
                    .ToList();

                if (responses.Count == 0)
                {
                    var emptyLabel = new Label()
                    {
                        Text = "Нет откликов на проект.",
                        AutoSize = true,
                        ForeColor = Color.Gray,
                        Font = new Font("Segoe UI", 10, FontStyle.Italic),
                        Margin = new Padding(10)
                    };
                    flowLayoutPanelResp.Controls.Add(emptyLabel);
                    return;
                }

                foreach (var response in responses)
                {
                    var control = new UserRequestItem(response, _user.user_id);
                    control.Width = flowLayoutPanelResp.Width - 25;
                    control.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
                    flowLayoutPanelResp.Controls.Add(control);
                }
            }
        }

    }
}
