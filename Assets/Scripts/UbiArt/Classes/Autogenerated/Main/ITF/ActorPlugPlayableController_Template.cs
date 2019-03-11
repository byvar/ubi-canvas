using UnityEngine;

namespace UbiArt.ITF {
	public partial class ActorPlugPlayableController_Template : ActorPlugBaseController_Template {
		[Serialize("unplugInputAction")] public StringID unplugInputAction;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(unplugInputAction));
		}
		public override uint? ClassCRC => 0xF961057F;
	}
}

