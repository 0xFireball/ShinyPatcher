#region Copyright and License Header

/*

	ShinyPatcher

	Copyright (c) 2016 0xFireball, IridiumIon Software

	Author(s): 0xFireball

	This file is part of ShinyPatcher.

	ShinyPatcher is free software: you can redistribute it and/or modify
	it under the terms of the GNU General Public License as published by
	the Free Software Foundation, either version 3 of the License, or
	(at your option) any later version.

	ShinyPatcher is distributed in the hope that it will be useful,
	but WITHOUT ANY WARRANTY; without even the implied warranty of
	MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
	GNU General Public License for more details.

	You should have received a copy of the GNU General Public License
	along with ShinyPatcher.  If not, see <http://www.gnu.org/licenses/>.

*/

#endregion Copyright and License Header

using NanoMvvm;
using ShinyPatcher.States;
using System.Windows.Input;

namespace ShinyPatcher.VM
{
    internal class MainWindowVM : ViewModelBase
    {
        private MainWindowState _state = new MainWindowState();

        public ICommand VisitIridiumIonCommand => new DelegateCommand(VisitIridiumIon);

        private void VisitIridiumIon(object obj)
        {
            _state.VisitIridiumIon();
        }
    }
}