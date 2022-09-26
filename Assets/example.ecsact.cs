#nullable enable

namespace example {
	/// <summary>struct representation of the Ecsact Component from package <c>example</c></summary>
	public struct Example : Ecsact.Component {
		public static readonly System.Int32 id = 0;

		public System.Int32 example_value;

		public override bool Equals(object? obj) {
			if((obj == null) || !this.GetType().Equals(obj.GetType())) {
				return false;
			}
			var other_ = (Example)obj;
			return true
				&& other_.example_value.Equals(example_value);
		}

		public override int GetHashCode() {
			int hashCode = 17;
			hashCode = hashCode * 23 + example_value.GetHashCode();
			return hashCode;
		}
	}

	/// <summary>struct representation of the Ecsact Component from package <c>example</c></summary>
	public struct ToBeRemoved : Ecsact.Component {
		public static readonly System.Int32 id = 1;


		public override bool Equals(object? obj) {
			if((obj == null) || !this.GetType().Equals(obj.GetType())) {
				return false;
			}
			var other_ = (ToBeRemoved)obj;
			return true;
		}

		public override int GetHashCode() {
			int hashCode = 17;
			return hashCode;
		}
	}

	/// <summary>struct representation of the Ecsact Component from package <c>example</c></summary>
	public struct CanMove : Ecsact.Component {
		public static readonly System.Int32 id = 3;


		public override bool Equals(object? obj) {
			if((obj == null) || !this.GetType().Equals(obj.GetType())) {
				return false;
			}
			var other_ = (CanMove)obj;
			return true;
		}

		public override int GetHashCode() {
			int hashCode = 17;
			return hashCode;
		}
	}

	/// <summary>struct representation of the Ecsact Component from package <c>example</c></summary>
	public struct VerticalMoving : Ecsact.Component {
		public static readonly System.Int32 id = 4;

		public System.Single value;

		public override bool Equals(object? obj) {
			if((obj == null) || !this.GetType().Equals(obj.GetType())) {
				return false;
			}
			var other_ = (VerticalMoving)obj;
			return true
				&& other_.value.Equals(value);
		}

		public override int GetHashCode() {
			int hashCode = 17;
			hashCode = hashCode * 23 + value.GetHashCode();
			return hashCode;
		}
	}

	/// <summary>struct representation of the Ecsact Component from package <c>example</c></summary>
	public struct HorizontalMoving : Ecsact.Component {
		public static readonly System.Int32 id = 5;

		public System.Single value;

		public override bool Equals(object? obj) {
			if((obj == null) || !this.GetType().Equals(obj.GetType())) {
				return false;
			}
			var other_ = (HorizontalMoving)obj;
			return true
				&& other_.value.Equals(value);
		}

		public override int GetHashCode() {
			int hashCode = 17;
			hashCode = hashCode * 23 + value.GetHashCode();
			return hashCode;
		}
	}

	/// <summary>struct representation of the Ecsact Component from package <c>example</c></summary>
	public struct Velocity : Ecsact.Component {
		public static readonly System.Int32 id = 6;

		public System.Single x_value;
		public System.Single y_value;
		public System.Single force;

		public override bool Equals(object? obj) {
			if((obj == null) || !this.GetType().Equals(obj.GetType())) {
				return false;
			}
			var other_ = (Velocity)obj;
			return true
				&& other_.x_value.Equals(x_value)
				&& other_.y_value.Equals(y_value)
				&& other_.force.Equals(force);
		}

		public override int GetHashCode() {
			int hashCode = 17;
			hashCode = hashCode * 23 + x_value.GetHashCode();
			hashCode = hashCode * 23 + y_value.GetHashCode();
			hashCode = hashCode * 23 + force.GetHashCode();
			return hashCode;
		}
	}

	/// <summary>struct representation of the Ecsact Component from package <c>example</c></summary>
	public struct Position : Ecsact.Component {
		public static readonly System.Int32 id = 11;

		public System.Single x;
		public System.Single y;
		public System.Single prev_x;
		public System.Single prev_y;

		public override bool Equals(object? obj) {
			if((obj == null) || !this.GetType().Equals(obj.GetType())) {
				return false;
			}
			var other_ = (Position)obj;
			return true
				&& other_.x.Equals(x)
				&& other_.y.Equals(y)
				&& other_.prev_x.Equals(prev_x)
				&& other_.prev_y.Equals(prev_y);
		}

		public override int GetHashCode() {
			int hashCode = 17;
			hashCode = hashCode * 23 + x.GetHashCode();
			hashCode = hashCode * 23 + y.GetHashCode();
			hashCode = hashCode * 23 + prev_x.GetHashCode();
			hashCode = hashCode * 23 + prev_y.GetHashCode();
			return hashCode;
		}
	}

	/// <summary>struct representation of the Ecsact Component from package <c>example</c></summary>
	public struct Collider : Ecsact.Component {
		public static readonly System.Int32 id = 12;

		public System.Int32 x_radius;
		public System.Int32 y_radius;

		public override bool Equals(object? obj) {
			if((obj == null) || !this.GetType().Equals(obj.GetType())) {
				return false;
			}
			var other_ = (Collider)obj;
			return true
				&& other_.x_radius.Equals(x_radius)
				&& other_.y_radius.Equals(y_radius);
		}

		public override int GetHashCode() {
			int hashCode = 17;
			hashCode = hashCode * 23 + x_radius.GetHashCode();
			hashCode = hashCode * 23 + y_radius.GetHashCode();
			return hashCode;
		}
	}

	/// <summary>struct representation of the Ecsact Component from package <c>example</c></summary>
	public struct Block : Ecsact.Component {
		public static readonly System.Int32 id = 18;


		public override bool Equals(object? obj) {
			if((obj == null) || !this.GetType().Equals(obj.GetType())) {
				return false;
			}
			var other_ = (Block)obj;
			return true;
		}

		public override int GetHashCode() {
			int hashCode = 17;
			return hashCode;
		}
	}

	/// <summary>struct representation of the Ecsact Component from package <c>example</c></summary>
	public struct BlockGenerator : Ecsact.Component {
		public static readonly System.Int32 id = 19;

		public System.Int32 fake_value;

		public override bool Equals(object? obj) {
			if((obj == null) || !this.GetType().Equals(obj.GetType())) {
				return false;
			}
			var other_ = (BlockGenerator)obj;
			return true
				&& other_.fake_value.Equals(fake_value);
		}

		public override int GetHashCode() {
			int hashCode = 17;
			hashCode = hashCode * 23 + fake_value.GetHashCode();
			return hashCode;
		}
	}

	/// <summary>struct representation of the Ecsact Component from package <c>example</c></summary>
	public struct QueueBlock : Ecsact.Component {
		public static readonly System.Int32 id = 20;

		public System.Int32 pos_x;
		public System.Int32 pos_y;

		public override bool Equals(object? obj) {
			if((obj == null) || !this.GetType().Equals(obj.GetType())) {
				return false;
			}
			var other_ = (QueueBlock)obj;
			return true
				&& other_.pos_x.Equals(pos_x)
				&& other_.pos_y.Equals(pos_y);
		}

		public override int GetHashCode() {
			int hashCode = 17;
			hashCode = hashCode * 23 + pos_x.GetHashCode();
			hashCode = hashCode * 23 + pos_y.GetHashCode();
			return hashCode;
		}
	}

	/// <summary>struct representation of the Ecsact Action from package <c>example</c></summary>
	public struct StartVerticalMove : Ecsact.Action {
		public static readonly System.Int32 id = 7;

		public System.Single y_change;

		public override bool Equals(object? obj) {
			if((obj == null) || !this.GetType().Equals(obj.GetType())) {
				return false;
			}
			var other_ = (StartVerticalMove)obj;
			return true
				&& other_.y_change.Equals(y_change);
		}

		public override int GetHashCode() {
			int hashCode = 17;
			hashCode = hashCode * 23 + y_change.GetHashCode();
			return hashCode;
		}
	}

	/// <summary>struct representation of the Ecsact Action from package <c>example</c></summary>
	public struct StopVerticalMove : Ecsact.Action {
		public static readonly System.Int32 id = 8;


		public override bool Equals(object? obj) {
			if((obj == null) || !this.GetType().Equals(obj.GetType())) {
				return false;
			}
			var other_ = (StopVerticalMove)obj;
			return true;
		}

		public override int GetHashCode() {
			int hashCode = 17;
			return hashCode;
		}
	}

	/// <summary>struct representation of the Ecsact Action from package <c>example</c></summary>
	public struct StartHorizontalMove : Ecsact.Action {
		public static readonly System.Int32 id = 9;

		public System.Single x_change;

		public override bool Equals(object? obj) {
			if((obj == null) || !this.GetType().Equals(obj.GetType())) {
				return false;
			}
			var other_ = (StartHorizontalMove)obj;
			return true
				&& other_.x_change.Equals(x_change);
		}

		public override int GetHashCode() {
			int hashCode = 17;
			hashCode = hashCode * 23 + x_change.GetHashCode();
			return hashCode;
		}
	}

	/// <summary>struct representation of the Ecsact Action from package <c>example</c></summary>
	public struct StopHorizontalMove : Ecsact.Action {
		public static readonly System.Int32 id = 10;


		public override bool Equals(object? obj) {
			if((obj == null) || !this.GetType().Equals(obj.GetType())) {
				return false;
			}
			var other_ = (StopHorizontalMove)obj;
			return true;
		}

		public override int GetHashCode() {
			int hashCode = 17;
			return hashCode;
		}
	}

	/// <summary>struct representation of the Ecsact Action from package <c>example</c></summary>
	public struct PerformGenerateBlock : Ecsact.Action {
		public static readonly System.Int32 id = 21;

		public System.Int32 pos_x;
		public System.Int32 pos_y;

		public override bool Equals(object? obj) {
			if((obj == null) || !this.GetType().Equals(obj.GetType())) {
				return false;
			}
			var other_ = (PerformGenerateBlock)obj;
			return true
				&& other_.pos_x.Equals(pos_x)
				&& other_.pos_y.Equals(pos_y);
		}

		public override int GetHashCode() {
			int hashCode = 17;
			hashCode = hashCode * 23 + pos_x.GetHashCode();
			hashCode = hashCode * 23 + pos_y.GetHashCode();
			return hashCode;
		}
	}

	/// <summary>struct representation of the Ecsact System from package <c>example</c></summary>
	public struct AddToExample : Ecsact.System {
		public static readonly System.Int32 id = 2;

	}

	/// <summary>struct representation of the Ecsact System from package <c>example</c></summary>
	public struct UpdateVerticalVelocity : Ecsact.System {
		public static readonly System.Int32 id = 13;

	}

	/// <summary>struct representation of the Ecsact System from package <c>example</c></summary>
	public struct UpdateHorizontalVelocity : Ecsact.System {
		public static readonly System.Int32 id = 14;

	}

	/// <summary>struct representation of the Ecsact System from package <c>example</c></summary>
	public struct CheckCollision : Ecsact.System {
		public static readonly System.Int32 id = 16;

	}

	/// <summary>struct representation of the Ecsact System from package <c>example</c></summary>
	public struct UpdatePosition : Ecsact.System {
		public static readonly System.Int32 id = 17;

	}

	/// <summary>struct representation of the Ecsact System from package <c>example</c></summary>
	public struct GenerateBlock : Ecsact.System {
		public static readonly System.Int32 id = 22;

	}

}

