using System;
using System.Linq;
using System.Windows.Forms;
using LibraryEFCore.Context;
using LibraryEFCore.DataAccess;
using LibraryEFCore.Models;

namespace LibraryUI.Forms.UserControls
{
    public partial class RaporCard : UserControl
    {
        private readonly AppRapor _rapor; // Seçilen rapor
        private readonly Action _listeYenile;
        private RaporRepository _raporRepository;
        public RaporCard(AppRapor rapor, Action listeYenile)
        {
            InitializeComponent();
            _rapor = rapor;
            _raporRepository = new RaporRepository(new LibraryContext());   
            _listeYenile = listeYenile;

            // Rapor bilgilerini yükle
            txtId.Text = _rapor.Id.ToString();
            txtTarih.Text = _rapor.Tarih.ToString("dd MMM yyyy");
            listBoxRapor.Items.Add(_rapor.Description);

            toolTip1.SetToolTip(btnSil, "Raporu Sil");
            toolTip1.SetToolTip(btnDetay, "Rapor Detayları");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                // Onay al
                var sonuc = MessageBox.Show($"{_rapor.Description} raporunu silmek istediğinize emin misiniz?",
                                            "Silme Onayı",
                                            MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Warning);

                if (sonuc == DialogResult.Yes)
                {
                    using (var context = new LibraryContext())
                    {
                        // Raporu bul ve sil
                        var rapor = context.AppRapors.Find(_rapor.Id);
                        if (rapor != null)
                        {
                            context.AppRapors.Remove(rapor); // Silme işlemi
                            _raporRepository.RaporEkle("Rapor silindi: " + _rapor.Description);
                            context.SaveChanges(); // Veritabanına kaydet

                            MessageBox.Show("Rapor başarıyla silindi!", "Başarılı",
                                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Listeyi yenile
                            _listeYenile?.Invoke();
                        }
                        else
                        {
                            MessageBox.Show("Rapor bulunamadı!", "Hata",
                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDetay_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Tarih: {_rapor.Tarih:dd MMM yyyy}\nAçıklama: {_rapor.Description}", "Rapor Detayları",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void RaporCard_Load(object sender, EventArgs e)
        {

        }
    }
}
