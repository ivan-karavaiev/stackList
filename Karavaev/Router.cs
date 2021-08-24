using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Karavaev
{
    /// <summary>
    /// Router is singleton, responsible for forms routing. Usage: Router.GetInstance()...
    /// </summary>
    public class Router
    {
        private Router()
        {
        }
        
        private readonly Stack<Form> _callStack = new Stack<Form>();
        
        private static Router _instance;

        public static Router GetInstance()
        {
            return _instance ?? (_instance = new Router());
        }

        public void NavigateTo(Form nextForm)
        {
            if (_callStack.Count != 0) _callStack.Peek().Hide();
            
            _callStack.Push(nextForm);
            nextForm.Show();
        }

        public void GoBack()
        {
            if (_callStack.Count <= 1) return;

            _callStack.Pop().Hide();
            _callStack.Peek().Show();
        }
    }
}