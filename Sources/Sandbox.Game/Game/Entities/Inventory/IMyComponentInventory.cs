﻿using Sandbox.Common.ObjectBuilders;
using Sandbox.Definitions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VRage;

namespace Sandbox.Game
{
	public interface IMyComponentInventory
	{
		IMyInventoryOwner Owner { get; }

		MyFixedPoint ComputeAmountThatFits(MyDefinitionId contentId);
		MyFixedPoint GetItemAmount(MyDefinitionId contentId, MyItemFlags flags = MyItemFlags.None);

        /// <summary>
        /// Adds item to inventory
        /// </summary>
        /// <param name="amount"></param>
        /// <param name="objectBuilder"></param>
        /// <param name="index"></param>
        /// <returns>true if items were added, false if items didn't fit</returns>
		bool AddItems(MyFixedPoint amount, MyObjectBuilder_PhysicalObject objectBuilder, int index = -1);
		void RemoveItemsOfType(MyFixedPoint amount, MyDefinitionId contentId, MyItemFlags flags = MyItemFlags.None, bool spawn = false);
	}
}
