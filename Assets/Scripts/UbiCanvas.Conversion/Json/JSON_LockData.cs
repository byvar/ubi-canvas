using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UbiArt;
using UbiArt.ITF;

namespace UbiCanvas.Conversion.Json {
	public class JSON_LockData {
		public uint LockCount { get; set; }
		public RO2_GameManagerConfig_Template.LockDataClass.MapLockType LockType { get; set; }
		//public string Parent { get; set; }
		//public RO2_GameManagerConfig_Template.LockDataClass.NodeBehaviorType BehaviorType { get; set; }
	}
}
