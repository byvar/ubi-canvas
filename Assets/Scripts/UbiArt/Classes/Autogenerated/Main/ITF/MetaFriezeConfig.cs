using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH | GameFlags.COL)]
	public partial class MetaFriezeConfig : TemplatePickable {
		public CListO<MetaFriezeParams> _params;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.COL) {
			} else {
				_params = s.SerializeObject<CListO<MetaFriezeParams>>(_params, name: "params");
			}
		}
		public override uint? ClassCRC => 0x11626154;
	}
}

