using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF {
	public class AnimResourcePackage : BaseObject {
		[Serialize(0, "skeleton")] public Path skeleton;
		[Serialize(1, "textureBank")] public Container<TextureBankPath> textureBank;
		[Serialize(2, "animPathAABB")] public Container<AnimPathAABB> animPathAABB;
		[Serialize(3, "needPack")] public bool needPack;
		[Serialize(4, "packed")] public bool packed;
		[Serialize(5, "fromHD")] public bool fromHD;

		public AnimResourcePackage(Reader reader) : base(reader) {
		}
	}
}
