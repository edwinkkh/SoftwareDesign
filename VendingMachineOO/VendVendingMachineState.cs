//
// ICT2106 Software Design - Vending machine example using the State pattern
//
// Class representing a vending machine in the "vend" state.
//
// Author: Nicholas Sheppard
//

namespace ICT2106.VendingMachineOO
{
    class VendVendingMachineState : VendingMachineState
    {
        private decimal cost;
        // constructor
        public VendVendingMachineState(VendingMachine VMIn, decimal costIn) : base(VMIn)
        {
            cost = costIn;
        }

        // enter state handler
        public override void OnEntry()
        {
            // print a message
            VM.Display("Vending an item worth $" + cost);

            // reduce the amount of money by the cost of the item and print a message
            VM.Amount -= cost;

            // display a message and reset the amount of money in the machine
            if (VM.Amount == 0.0M)
            {
                // no change required; go back to idle
                VM.EnterState(new IdleVendingMachineState(VM));
            }
            else if (VM.MachineBalance >= VM.Amount)
            {
                // need to give change
                VM.EnterState(new MakeChangeVendingMachineState(VM));
            }

            else
            {
                VM.Display("Machine do not have money to return change");
                VM.Display("Cancelled order");
                VM.msg = "noenoughchange";

                // no change required; go back to idle
                VM.EnterState(new IdleVendingMachineState(VM));
            }
        }

        // insert money handler
        public override void Insert(decimal amountIn)
        {
            VM.Display("Please wait until the current item has been dispensed.");
        }

        // select item handler
        public override void Select(decimal cost)
        {
            VM.Display("Please wait until the current item has been dispensed.");
        }
    }
}
