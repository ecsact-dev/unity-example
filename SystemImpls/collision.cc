#include "example.ecsact.hh"
#include "example.ecsact.systems.hh"

void example::CollisionComparer::CheckCollision::impl(context& ctx) {
	if(ctx._ctx.same(ctx._ctx.parent())) return;

	auto position = ctx.get<Position>();
	auto velocity = ctx.get<Velocity>();

	auto otherPos = ctx._ctx.parent().get<Position>();
	auto other_collider = ctx._ctx.parent().get<Collider>();

	auto xDiff = std::abs(position.x - otherPos.x);
	auto yDiff = std::abs(position.y - otherPos.y);
	
	if(xDiff <= other_collider.x_radius && yDiff <= other_collider.y_radius) {
		position.x = position.prev_x;
		position.y = position.prev_y;

		if(position.x < otherPos.x) {
			velocity.x_value = -0.5f;
		} else {
			velocity.x_value = 0.5f;
		}

		if(position.y < otherPos.y) {
			velocity.y_value = -0.5f;
		} else {
			velocity.y_value = 0.5f;
		}
		
		ctx.update<Velocity>(velocity);
		ctx.update<Position>(position);
	}
}
