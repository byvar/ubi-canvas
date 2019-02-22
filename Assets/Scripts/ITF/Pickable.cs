using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF {
	public class Pickable : BaseObject {
		protected GameObject gao;
		public GameObject Gao {
			get {
				if (gao == null) {
					InitGameObject();
				}
				return gao;
			}
		}

		protected virtual void InitGameObject() {
			gao = new GameObject(userFriendly);
			gao.transform.localPosition = new Vector3(pos2D.x, pos2D.y, -relativeZ);
			gao.transform.localScale = new Vector3(scale.x, scale.y, 1f);
		}

		public float relativeZ;
		public Vector2 scale = Vector2.one;
		public bool xFlipped;
		public string userFriendly;
		public uint updateDependencyList;
		public Vector2 pos2D;
		public Angle angle;
		public Path instanceDataFile;


		public Pickable(Reader reader) : base(reader) {
			relativeZ = reader.ReadSingle();
			scale = reader.ReadVector2();
			xFlipped = reader.ReadBoolean();
			userFriendly = reader.ReadString();
			updateDependencyList = reader.ReadUInt32();
			pos2D = reader.ReadVector2();
			angle = new Angle(reader);
			instanceDataFile = new Path(reader);
		}
		public bool CheckFlags(uint flags) {
			return true; // todo
		}
	}
}
