using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RLVersion)]
	public partial class RedirectSymmetryPatch : CSerializable {
		public StringID mainPatch;
		public StringID boneName;
		public StringID symmetryPatch;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			mainPatch = s.SerializeObject<StringID>(mainPatch, name: "mainPatch");
			boneName = s.SerializeObject<StringID>(boneName, name: "boneName");
			symmetryPatch = s.SerializeObject<StringID>(symmetryPatch, name: "symmetryPatch");
		}
	}
}
