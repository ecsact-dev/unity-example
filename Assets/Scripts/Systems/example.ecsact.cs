// GENERATED FILE - DO NOT EDIT

#nullable enable

namespace example {

public struct Example : global::Ecsact.Component {
	public static readonly global::System.Int32 id = 1;
	public global::System.Int32 example_value;

	public override bool Equals(object? obj) {
		if(obj == null) return false;
		var other_ = (example.Example)obj;
		return true
			&& other_.example_value.Equals(this.example_value);
	}

	public override int GetHashCode() {
		int hashCode_ = 17;
		hashCode_ = hashCode_ * 23 + example_value.GetHashCode();
		return hashCode_;
	}
}

public struct ToBeRemoved : global::Ecsact.Component {
	public static readonly global::System.Int32 id = 2;

	public override bool Equals(object? obj) {
		if(obj == null) return false;
		var other_ = (example.ToBeRemoved)obj;
		return true;
	}

	public override int GetHashCode() {
		int hashCode_ = 17;
		return hashCode_;
	}
}

public struct CanMove : global::Ecsact.Component {
	public static readonly global::System.Int32 id = 4;

	public override bool Equals(object? obj) {
		if(obj == null) return false;
		var other_ = (example.CanMove)obj;
		return true;
	}

	public override int GetHashCode() {
		int hashCode_ = 17;
		return hashCode_;
	}
}

public struct VerticalMoving : global::Ecsact.Component {
	public static readonly global::System.Int32 id = 5;
	public global::System.Single value;

	public override bool Equals(object? obj) {
		if(obj == null) return false;
		var other_ = (example.VerticalMoving)obj;
		return true
			&& other_.value.Equals(this.value);
	}

	public override int GetHashCode() {
		int hashCode_ = 17;
		hashCode_ = hashCode_ * 23 + value.GetHashCode();
		return hashCode_;
	}
}

public struct HorizontalMoving : global::Ecsact.Component {
	public static readonly global::System.Int32 id = 6;
	public global::System.Single value;

	public override bool Equals(object? obj) {
		if(obj == null) return false;
		var other_ = (example.HorizontalMoving)obj;
		return true
			&& other_.value.Equals(this.value);
	}

	public override int GetHashCode() {
		int hashCode_ = 17;
		hashCode_ = hashCode_ * 23 + value.GetHashCode();
		return hashCode_;
	}
}

public struct Velocity : global::Ecsact.Component {
	public static readonly global::System.Int32 id = 7;
	public global::System.Single x_value;
	public global::System.Single y_value;
	public global::System.Single force;

	public override bool Equals(object? obj) {
		if(obj == null) return false;
		var other_ = (example.Velocity)obj;
		return true
			&& other_.x_value.Equals(this.x_value)
			&& other_.y_value.Equals(this.y_value)
			&& other_.force.Equals(this.force);
	}

	public override int GetHashCode() {
		int hashCode_ = 17;
		hashCode_ = hashCode_ * 23 + x_value.GetHashCode();
		hashCode_ = hashCode_ * 23 + y_value.GetHashCode();
		hashCode_ = hashCode_ * 23 + force.GetHashCode();
		return hashCode_;
	}
}

public struct Position : global::Ecsact.Component {
	public static readonly global::System.Int32 id = 8;
	public global::System.Single x;
	public global::System.Single y;
	public global::System.Single prev_x;
	public global::System.Single prev_y;

	public override bool Equals(object? obj) {
		if(obj == null) return false;
		var other_ = (example.Position)obj;
		return true
			&& other_.x.Equals(this.x)
			&& other_.y.Equals(this.y)
			&& other_.prev_x.Equals(this.prev_x)
			&& other_.prev_y.Equals(this.prev_y);
	}

	public override int GetHashCode() {
		int hashCode_ = 17;
		hashCode_ = hashCode_ * 23 + x.GetHashCode();
		hashCode_ = hashCode_ * 23 + y.GetHashCode();
		hashCode_ = hashCode_ * 23 + prev_x.GetHashCode();
		hashCode_ = hashCode_ * 23 + prev_y.GetHashCode();
		return hashCode_;
	}
}

public struct Collider : global::Ecsact.Component {
	public static readonly global::System.Int32 id = 9;
	public global::System.Int32 x_radius;
	public global::System.Int32 y_radius;

	public override bool Equals(object? obj) {
		if(obj == null) return false;
		var other_ = (example.Collider)obj;
		return true
			&& other_.x_radius.Equals(this.x_radius)
			&& other_.y_radius.Equals(this.y_radius);
	}

	public override int GetHashCode() {
		int hashCode_ = 17;
		hashCode_ = hashCode_ * 23 + x_radius.GetHashCode();
		hashCode_ = hashCode_ * 23 + y_radius.GetHashCode();
		return hashCode_;
	}
}

public struct Block : global::Ecsact.Component {
	public static readonly global::System.Int32 id = 10;

	public override bool Equals(object? obj) {
		if(obj == null) return false;
		var other_ = (example.Block)obj;
		return true;
	}

	public override int GetHashCode() {
		int hashCode_ = 17;
		return hashCode_;
	}
}

public struct BlockGenerator : global::Ecsact.Component {
	public static readonly global::System.Int32 id = 11;
	public global::System.Int32 fake_value;

	public override bool Equals(object? obj) {
		if(obj == null) return false;
		var other_ = (example.BlockGenerator)obj;
		return true
			&& other_.fake_value.Equals(this.fake_value);
	}

	public override int GetHashCode() {
		int hashCode_ = 17;
		hashCode_ = hashCode_ * 23 + fake_value.GetHashCode();
		return hashCode_;
	}
}

public struct QueueBlock : global::Ecsact.Component {
	public static readonly global::System.Int32 id = 12;
	public global::System.Int32 pos_x;
	public global::System.Int32 pos_y;

	public override bool Equals(object? obj) {
		if(obj == null) return false;
		var other_ = (example.QueueBlock)obj;
		return true
			&& other_.pos_x.Equals(this.pos_x)
			&& other_.pos_y.Equals(this.pos_y);
	}

	public override int GetHashCode() {
		int hashCode_ = 17;
		hashCode_ = hashCode_ * 23 + pos_x.GetHashCode();
		hashCode_ = hashCode_ * 23 + pos_y.GetHashCode();
		return hashCode_;
	}
}

public struct StartVerticalMove : global::Ecsact.Action {
	public static readonly global::System.Int32 id = 13;
	public global::System.Single y_change;

	public override bool Equals(object? obj) {
		if(obj == null) return false;
		var other_ = (example.StartVerticalMove)obj;
		return true
			&& other_.y_change.Equals(this.y_change);
	}

	public override int GetHashCode() {
		int hashCode_ = 17;
		hashCode_ = hashCode_ * 23 + y_change.GetHashCode();
		return hashCode_;
	}
}

public struct StopVerticalMove : global::Ecsact.Action {
	public static readonly global::System.Int32 id = 14;

	public override bool Equals(object? obj) {
		if(obj == null) return false;
		var other_ = (example.StopVerticalMove)obj;
		return true;
	}

	public override int GetHashCode() {
		int hashCode_ = 17;
		return hashCode_;
	}
}

public struct StartHorizontalMove : global::Ecsact.Action {
	public static readonly global::System.Int32 id = 15;
	public global::System.Single x_change;

	public override bool Equals(object? obj) {
		if(obj == null) return false;
		var other_ = (example.StartHorizontalMove)obj;
		return true
			&& other_.x_change.Equals(this.x_change);
	}

	public override int GetHashCode() {
		int hashCode_ = 17;
		hashCode_ = hashCode_ * 23 + x_change.GetHashCode();
		return hashCode_;
	}
}

public struct StopHorizontalMove : global::Ecsact.Action {
	public static readonly global::System.Int32 id = 16;

	public override bool Equals(object? obj) {
		if(obj == null) return false;
		var other_ = (example.StopHorizontalMove)obj;
		return true;
	}

	public override int GetHashCode() {
		int hashCode_ = 17;
		return hashCode_;
	}
}

public struct PerformGenerateBlock : global::Ecsact.Action {
	public static readonly global::System.Int32 id = 22;
	public global::System.Int32 pos_x;
	public global::System.Int32 pos_y;

	public override bool Equals(object? obj) {
		if(obj == null) return false;
		var other_ = (example.PerformGenerateBlock)obj;
		return true
			&& other_.pos_x.Equals(this.pos_x)
			&& other_.pos_y.Equals(this.pos_y);
	}

	public override int GetHashCode() {
		int hashCode_ = 17;
		hashCode_ = hashCode_ * 23 + pos_x.GetHashCode();
		hashCode_ = hashCode_ * 23 + pos_y.GetHashCode();
		return hashCode_;
	}
}
public struct AddToExample : global::Ecsact.System {
	public static readonly global::System.Int32 id = 3;
}
public struct UpdateVerticalVelocity : global::Ecsact.System {
	public static readonly global::System.Int32 id = 17;
}
public struct UpdateHorizontalVelocity : global::Ecsact.System {
	public static readonly global::System.Int32 id = 18;
}
public struct CollisionComparer : global::Ecsact.System {
	public static readonly global::System.Int32 id = 19;
	public struct CheckCollision : global::Ecsact.System {
		public static readonly global::System.Int32 id = 20;
	}
}
public struct UpdatePosition : global::Ecsact.System {
	public static readonly global::System.Int32 id = 21;
}
public struct GenerateBlock : global::Ecsact.System {
	public static readonly global::System.Int32 id = 23;
}
public struct RemoveQueueBlock : global::Ecsact.System {
	public static readonly global::System.Int32 id = 25;
}

}
