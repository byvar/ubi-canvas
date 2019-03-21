using UnityEngine;

namespace UbiArt.ITF {
	public partial class RegionPathList : CSerializable {
		[Serialize("RegionBackgroundPath")] public CList<Path> RegionBackgroundPath;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(RegionBackgroundPath));
		}
	}
}

