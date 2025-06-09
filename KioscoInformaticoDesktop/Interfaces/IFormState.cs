using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop.Interfaces
{
    public interface IFormState
    {
        void OnSearch();
        void OnAdd();
        void OnEdit();
        void OnDelete();
        void OnSave();
        void OnCancel();
        void OnGoOut();
        Task UpdateUI();
    }
}
