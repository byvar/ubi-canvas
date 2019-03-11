using UnityEngine;

namespace UbiArt.ITF {
	public partial class BTAIComponent : EntityComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xEBC372C1;
	}
}

