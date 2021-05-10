﻿using LogicalSchemeInterpretor.Commands;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalSchemeInterpretor.CommandConfig
{
    class CommandGraph : ICommandConfiguration
    {
        private Hashtable _graph;

        public Hashtable Graph {
            get => _graph;
            set => _graph = value;
        }
        public List<ICommand> CommandList { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); }

        public void AddElement(ICommand command)
        {
            if (!_graph.ContainsKey(command))
            {
                _graph.Add(command, new Tuple<ICommand, ICommand>(null, null));
            }
        }

        public void BindElementFirst(ICommand father, ICommand firstSon)
        {
            if (_graph.ContainsKey(father))
            {
                Tuple<ICommand, ICommand> element = (Tuple<ICommand, ICommand>)_graph[father];
                Tuple<ICommand, ICommand> elementNew = new Tuple<ICommand, ICommand>(firstSon, element.Item2);
                _graph.Remove(father);
                _graph.Add(father, elementNew);
            }
        }

        public void BindElementSecond(ICommand father, ICommand secondSon)
        {

            if (_graph.ContainsKey(father))
            {
                Tuple<ICommand, ICommand> element = (Tuple<ICommand, ICommand>)_graph[father];
                Tuple<ICommand, ICommand> elementNew = new Tuple<ICommand, ICommand>(element.Item1, secondSon);
                _graph.Remove(father);
                _graph.Add(father, elementNew);
            }
        }

        public void RemoveElement(ICommand command)
        {
            throw new NotImplementedException();
        }
    }
}