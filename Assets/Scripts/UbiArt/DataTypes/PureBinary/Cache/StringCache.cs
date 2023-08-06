using System.Linq;
using UbiArt.ITF;

namespace UbiArt.Animation {
	// itf_cache/platform/string.cache
	public class StringCache : CSerializable {
		public CMap<StringID, string> Strings { get; set; }

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			Strings = s.SerializeObject<CMap<StringID, string>>(Strings, name: nameof(Strings));
		}
	}
}
