using IRepository.Migrator;
using System;
using System.Collections.Generic;
using System.Text;

namespace RippleYes.MicroCommands
{
    internal class MigrationCommand
    {
        public MigrationCommand(IMigrator migrator)
        {
            Migrator = migrator ?? throw new ArgumentNullException(nameof(migrator));
        }

        private readonly IMigrator Migrator;

        public void Execute()
        {
            Migrator.Run();
        }
    }
}
