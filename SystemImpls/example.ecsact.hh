// GENERATED FILE - DO NOT EDIT
#pragma once

#include <cstdint>
#include <compare>
#include "ecsact/runtime/common.h"

namespace example {

struct Example {
	static constexpr bool transient = false;
	static constexpr auto id = static_cast<ecsact_component_id>(1);
	int32_t example_value;
	auto operator<=>(const example::Example&) const = default;
};
struct ToBeRemoved {
	static constexpr bool transient = false;
	static constexpr auto id = static_cast<ecsact_component_id>(2);
	auto operator<=>(const example::ToBeRemoved&) const = default;
};
struct CanMove {
	static constexpr bool transient = false;
	static constexpr auto id = static_cast<ecsact_component_id>(4);
	auto operator<=>(const example::CanMove&) const = default;
};
struct Velocity {
	static constexpr bool transient = false;
	static constexpr auto id = static_cast<ecsact_component_id>(5);
	float x_value;
	float y_value;
	float speed;
	auto operator<=>(const example::Velocity&) const = default;
};
struct Position {
	static constexpr bool transient = false;
	static constexpr auto id = static_cast<ecsact_component_id>(6);
	float x;
	float y;
	float prev_x;
	float prev_y;
	auto operator<=>(const example::Position&) const = default;
};
struct Collider {
	static constexpr bool transient = false;
	static constexpr auto id = static_cast<ecsact_component_id>(7);
	int32_t x_radius;
	int32_t y_radius;
	auto operator<=>(const example::Collider&) const = default;
};
struct Block {
	static constexpr bool transient = false;
	static constexpr auto id = static_cast<ecsact_component_id>(8);
	auto operator<=>(const example::Block&) const = default;
};
struct BlockGenerator {
	static constexpr bool transient = false;
	static constexpr auto id = static_cast<ecsact_component_id>(9);
	auto operator<=>(const example::BlockGenerator&) const = default;
};
struct QueueBlock {
	static constexpr bool transient = false;
	static constexpr auto id = static_cast<ecsact_component_id>(14);
	int32_t pos_x;
	int32_t pos_y;
	auto operator<=>(const example::QueueBlock&) const = default;
};
struct Move {
	static constexpr auto id = static_cast<ecsact_action_id>(10);
	struct context;
	static void impl(context&);
	float dir_x;
	float dir_y;
	auto operator<=>(const example::Move&) const = default;
};
struct PerformGenerateBlock {
	static constexpr auto id = static_cast<ecsact_action_id>(15);
	struct context;
	static void impl(context&);
	int32_t pos_x;
	int32_t pos_y;
	auto operator<=>(const example::PerformGenerateBlock&) const = default;
};
struct AddToExample {
	static constexpr auto id = static_cast<ecsact_system_id>(3);
	struct context;
	static void impl(context&);
};
struct CollisionComparer {
	static constexpr auto id = static_cast<ecsact_system_id>(11);
	struct CheckCollision {
		static constexpr auto id = static_cast<ecsact_system_id>(12);
		struct context;
		static void impl(context&);
	};
	struct context;
	static void impl(context&);
};
struct ApplyVelocity {
	static constexpr auto id = static_cast<ecsact_system_id>(13);
	struct context;
	static void impl(context&);
};
struct GenerateBlock {
	static constexpr auto id = static_cast<ecsact_system_id>(16);
	struct context;
	static void impl(context&);
};
struct RemoveQueueBlock {
	static constexpr auto id = static_cast<ecsact_system_id>(18);
	struct context;
	static void impl(context&);
};

}// namespace example
