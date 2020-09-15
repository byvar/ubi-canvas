using UnityEngine;

namespace UbiArt.ITF {
	public partial class RegionPathList : CSerializable {
		public CList<Path> RegionBackgroundPath;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			RegionBackgroundPath = s.SerializeObject<CList<Path>>(RegionBackgroundPath, name: "RegionBackgroundPath");
		}
	}
}

