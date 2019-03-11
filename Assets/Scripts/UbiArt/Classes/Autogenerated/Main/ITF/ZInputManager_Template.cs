using UnityEngine;

namespace UbiArt.ITF {
	public partial class ZInputManager_Template : TemplateObj {
		[Serialize("name"    )] public StringID name;
		[Serialize("config"  )] public StringID config;
		[Serialize("actions" )] public CList<ZAction> actions;
		[Serialize("category")] public uint category;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(name));
				SerializeField(s, nameof(config));
				SerializeField(s, nameof(category));
				SerializeField(s, nameof(actions));
			} else if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(name));
				SerializeField(s, nameof(config));
				SerializeField(s, nameof(category));
				SerializeField(s, nameof(actions));
			} else {
				SerializeField(s, nameof(name));
				SerializeField(s, nameof(config));
				SerializeField(s, nameof(actions));
			}
		}
		public override uint? ClassCRC => 0xD63A5C7E;
	}
}

