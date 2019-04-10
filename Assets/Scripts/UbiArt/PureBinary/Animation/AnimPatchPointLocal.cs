using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace UbiArt.Animation {
	// See: ITF::AnimPatchPointLocal::serialize
	public class AnimPatchPointLocal : CSerializable {
		[Serialize("link")] public Link link;
		[Serialize("vec0")] public Vector2 vec0;
		[Serialize("vec1")] public Vector2 vec1;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(link));
			SerializeField(s, nameof(vec0));
			SerializeField(s, nameof(vec1));
		}

		/*
		Example:
		10BDAF20 BF2043C43EA0387E 3622ED493F800000
		10BDAF20 BF13E671BE899696 B622ED49BF800000
		10BDAF20 3FA37B9E3EA90F73 3622ED493F800000
		10BDAF20 3F993501BE89F773 B622ED49BF800000
		*/

	}
}
