using System.Drawing;

namespace JumpingPlatformGame {
	class Entity {
		public virtual Color Color => Color.Black;
		public WorldPoint Location;
		public Seconds time;
		public void Update(Seconds s)
		{
			time += s;
		}
	}

	class MovableEntity : Entity {
		public Movement Horizontal, Vertical;
	}

	class MovableJumpingEntity : MovableEntity {
	}

	class Joe : MovableEntity {
		public override string ToString() => "Joe";
		public override Color Color => Color.Blue;
	}

	class Jack : MovableEntity {
		public override string ToString() => "Jack";
		public override Color Color => Color.LightBlue;
	}

	class Jane : MovableJumpingEntity {
		public override string ToString() => "Jane";
		public override Color Color => Color.Red;
	}

	class Jill : MovableJumpingEntity {
		public override string ToString() => "Jill";
		public override Color Color => Color.Pink;
	}

}