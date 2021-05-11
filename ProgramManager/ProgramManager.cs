using LogicalSchemeInterpretor.VarConfig;
using System;
using System.Collections.Generic;

namespace LogicalSchemeInterpretor.ProgramManager
{
    public class ProgramManager
    {
        private IVariableConfiguration _variableConfiguration;
        private ICommandConfiguration _commandConfiguration;
        private ICommand _currentCommand;

        public ProgramManager()
        {
            // initializez cele 2 componente primare
            _variableConfiguration = new GlobalVariables();
            _commandConfiguration = new CommandGraph();

            // trebuie sa existe o instanta de tip Eticheta cu numele "Start" pentru a incepe
            ICommand startCmd = new Command(new Eticheta("Start"));

            // adaug comanda in lista de comenzi
            _commandConfiguration.AddElement(startCmd);
        }

        public ProgramManager(string filePath)
        {
            throw new Exception("Functionality not implemented yet!");
        }

        public IVariableConfiguration AllVariables
        {
            get => _variableConfiguration;
            set => _variableConfiguration = value;
        }

        public ICommandConfiguration Connections
        {
            get => _commandConfiguration;
            set => _commandConfiguration = value;
        }

        public void RunProgram()
        {
            // se cauta eticheta cu numele "Start"
            List<ICommand> cmdList = _commandConfiguration.CommandList;

            ICommand startCommand = null;
            foreach (ICommand command in cmdList)
            {
                if (command.CommandType is Eticheta)
                {
                    Eticheta start = (Eticheta)(command.CommandType);
                    if (start.Name == "Start")
                    {
                        startCommand = command;
                        return;
                    }
                }
            }

            if (startCommand == null)
            {
                throw new Exception("Programul nu contine nicio eticheta cu numele de \"Start\"!");
            }

            // se realizeaza iterarea prin program
            ICommand programCounter = startCommand;

            // pornind din start, iteram
            while (programCounter != null)
            {
                try
                {
                    _currentCommand = programCounter;
                    programCounter.Execute();
                    bool isNextTrue = programCounter.CommandType.GetNext();
                    programCounter = _commandConfiguration.GetNextElement(programCounter, isNextTrue);
                }
                catch (Exception ex)
                {
                    // add command responsable for exception
                    throw new Exception(_currentCommand.ToString() + " has generated: " + ex.Message);
                }
            }

            _currentCommand = null;
        }
    }
}
