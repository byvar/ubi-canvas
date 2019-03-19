using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RO | GameFlags.RL | GameFlags.VH | GameFlags.COL)]
	public partial class ZInputManager_Template : TemplateObj {
		[Serialize("name"    )] public StringID name;
		[Serialize("config"  )] public StringID config;
		[Serialize("category")] public uint category;
		[Serialize("actions" )] public CList<ZAction> actions;
		[Serialize("mode"    )] public StringID mode;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(name));
				SerializeField(s, nameof(config));
				SerializeField(s, nameof(mode));
				SerializeField(s, nameof(category));
			} else {
				SerializeField(s, nameof(name));
				SerializeField(s, nameof(config));
				SerializeField(s, nameof(category));
				SerializeField(s, nameof(actions));
			}
		}
		public override uint? ClassCRC => 0xD63A5C7E;
	}
}

