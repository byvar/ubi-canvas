using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_BreakablePropsManagerComponent : ActorComponent {
		public uint lumsGiven;
		public uint lumsDrcGiven;
		public CList<uint> breakablePropsState;
		public CArray<bool> breakablePropsPaint;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				lumsGiven = s.Serialize<uint>(lumsGiven, name: "lumsGiven");
				lumsDrcGiven = s.Serialize<uint>(lumsDrcGiven, name: "lumsDrcGiven");
				if (s.HasFlags(SerializeFlags.Persistent)) {
					breakablePropsState = s.SerializeObject<CList<uint>>(breakablePropsState, name: "breakablePropsState");
					breakablePropsPaint = s.SerializeObject<CArray<bool>>(breakablePropsPaint, name: "breakablePropsPaint");
				}
			} else {
				lumsGiven = s.Serialize<uint>(lumsGiven, name: "lumsGiven");
				lumsDrcGiven = s.Serialize<uint>(lumsDrcGiven, name: "lumsDrcGiven");
				if (s.HasFlags(SerializeFlags.Persistent)) {
					breakablePropsState = s.SerializeObject<CList<uint>>(breakablePropsState, name: "breakablePropsState");
				}
				breakablePropsPaint = s.SerializeObject<CArray<bool>>(breakablePropsPaint, name: "breakablePropsPaint");
				breakablePropsPaint = s.SerializeObject<CArray<bool>>(breakablePropsPaint, name: "breakablePropsPaint");
			}
		}
		public override uint? ClassCRC => 0xF2DC9CA7;
	}
}

