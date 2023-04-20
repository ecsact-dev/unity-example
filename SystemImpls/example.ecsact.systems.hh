// GENERATED FILE - DO NOT EDIT
#pragma once

#include <type_traits>
#include "ecsact/cpp/execution_context.hh"
#include "example.ecsact.hh"
#include "example.ecsact.systems.h"

struct ecsact_system_execution_context;

struct example::AddToExample::context {
	[[no_unique_address]]
	::ecsact::execution_context _ctx;
	template<typename T>
	T get() {
		// local type to make static assert always fail
		struct red_herring {};
		static_assert(std::is_same_v<T, red_herring>, R"(

 | [Ecsact C++ Error]: System Execution Context Misuse
 | 
 | example.AddToExample context.get<T> may only be called with a component
 | readable by the system. Did you forget to add readonly or readwrite capabilities?
 | The following components are allowed:
 | 	- example.Example
 | )");
	}
	template<typename T>
	void update(const T& updated_component) {
		// local type to make static assert always fail
		struct red_herring {};
		static_assert(std::is_same_v<T, red_herring>, R"(

 | [Ecsact C++ Error]: System Execution Context Misuse
 | 
 | example.AddToExample context.update<T> may only be called with a component
 | writable by the system. Did you forget to add readwrite capabilities? The
 | following components are allowed:
 | 	- example.Example
 | )");
	}
	template<typename T>
	void remove() {
		// local type to make static assert always fail
		struct red_herring {};
		static_assert(std::is_same_v<T, red_herring>, R"(

 | [Ecsact C++ Error]: System Execution Context Misuse
 | 
 | example.AddToExample context.remove<T> may only be called with a component
 | removable by the system. Did you forget to add removes capabilities? The
 | following components are allowed:
 | 	- example.ToBeRemoved
 | )");
	}


	template<> example::Example get<example::Example>() {
		return _ctx.get<example::Example>();
	}
	template<> void update<example::Example>(const example::Example& updated_component) {
		_ctx.update<example::Example>(updated_component);
	}
	template<> void remove<example::ToBeRemoved>() {
		return _ctx.remove<example::ToBeRemoved>();
	}
	ecsact_entity_id entity() const {
		return _ctx.entity();
	}
};

struct example::CollisionComparer::context {
	[[no_unique_address]]
	::ecsact::execution_context _ctx;
	template<typename T>
	T get() {
		// local type to make static assert always fail
		struct red_herring {};
		static_assert(std::is_same_v<T, red_herring>, R"(

 | [Ecsact C++ Error]: System Execution Context Misuse
 | 
 | example.CollisionComparer context.get<T> may only be called with a component
 | readable by the system. Did you forget to add readonly or readwrite
 | capabilities? The following components are allowed:
 | 	- example.Position
 | 	- example.Collider
 | )");
	}


	template<> example::Position get<example::Position>() {
		return _ctx.get<example::Position>();
	}
	template<> example::Collider get<example::Collider>() {
		return _ctx.get<example::Collider>();
	}
	ecsact_entity_id entity() const {
		return _ctx.entity();
	}
};

struct example::CollisionComparer::CheckCollision::context {
	[[no_unique_address]]
	::ecsact::execution_context _ctx;
	template<typename T>
	T get() {
		// local type to make static assert always fail
		struct red_herring {};
		static_assert(std::is_same_v<T, red_herring>, R"(

 | [Ecsact C++ Error]: System Execution Context Misuse
 | 
 | example.CollisionComparer.CheckCollision context.get<T> may only be called
 | with a component readable by the system. Did you forget to add readonly or
 | readwrite capabilities? The following components are allowed:
 | 	- example.Velocity
 | 	- example.Position
 | 	- example.Collider
 | )");
	}
	template<typename T>
	void update(const T& updated_component) {
		// local type to make static assert always fail
		struct red_herring {};
		static_assert(std::is_same_v<T, red_herring>, R"(

 | [Ecsact C++ Error]: System Execution Context Misuse
 | 
 | example.CollisionComparer.CheckCollision context.update<T> may only be
 | called with a component writable by the system. Did you forget to add readwrite
 | capabilities? The following components are allowed:
 | 	- example.Velocity
 | 	- example.Position
 | 	- example.Collider
 | )");
	}
	const example::CollisionComparer::context parent() const;


	template<> example::Velocity get<example::Velocity>() {
		return _ctx.get<example::Velocity>();
	}
	template<> example::Position get<example::Position>() {
		return _ctx.get<example::Position>();
	}
	template<> example::Collider get<example::Collider>() {
		return _ctx.get<example::Collider>();
	}
	template<> void update<example::Velocity>(const example::Velocity& updated_component) {
		_ctx.update<example::Velocity>(updated_component);
	}
	template<> void update<example::Position>(const example::Position& updated_component) {
		_ctx.update<example::Position>(updated_component);
	}
	template<> void update<example::Collider>(const example::Collider& updated_component) {
		_ctx.update<example::Collider>(updated_component);
	}
	ecsact_entity_id entity() const {
		return _ctx.entity();
	}
};

struct example::ApplyVelocity::context {
	[[no_unique_address]]
	::ecsact::execution_context _ctx;
	template<typename T>
	T get() {
		// local type to make static assert always fail
		struct red_herring {};
		static_assert(std::is_same_v<T, red_herring>, R"(

 | [Ecsact C++ Error]: System Execution Context Misuse
 | 
 | example.ApplyVelocity context.get<T> may only be called with a component
 | readable by the system. Did you forget to add readonly or readwrite capabilities?
 | The following components are allowed:
 | 	- example.Velocity
 | 	- example.Position
 | )");
	}
	template<typename T>
	void update(const T& updated_component) {
		// local type to make static assert always fail
		struct red_herring {};
		static_assert(std::is_same_v<T, red_herring>, R"(

 | [Ecsact C++ Error]: System Execution Context Misuse
 | 
 | example.ApplyVelocity context.update<T> may only be called with a component
 | writable by the system. Did you forget to add readwrite capabilities? The
 | following components are allowed:
 | 	- example.Velocity
 | 	- example.Position
 | )");
	}


	template<> example::Velocity get<example::Velocity>() {
		return _ctx.get<example::Velocity>();
	}
	template<> example::Position get<example::Position>() {
		return _ctx.get<example::Position>();
	}
	template<> void update<example::Velocity>(const example::Velocity& updated_component) {
		_ctx.update<example::Velocity>(updated_component);
	}
	template<> void update<example::Position>(const example::Position& updated_component) {
		_ctx.update<example::Position>(updated_component);
	}
	ecsact_entity_id entity() const {
		return _ctx.entity();
	}
};

struct example::GenerateBlock::context {
	[[no_unique_address]]
	::ecsact::execution_context _ctx;
	template<typename T>
	T get() {
		// local type to make static assert always fail
		struct red_herring {};
		static_assert(std::is_same_v<T, red_herring>, R"(

 | [Ecsact C++ Error]: System Execution Context Misuse
 | 
 | example.GenerateBlock context.get<T> may only be called with a component
 | readable by the system. Did you forget to add readonly or readwrite capabilities?
 | The following components are allowed:
 | 	- example.QueueBlock
 | )");
	}
	template<typename T>
	void update(const T& updated_component) {
		// local type to make static assert always fail
		struct red_herring {};
		static_assert(std::is_same_v<T, red_herring>, R"(

 | [Ecsact C++ Error]: System Execution Context Misuse
 | 
 | example.GenerateBlock context.update<T> may only be called with a component
 | writable by the system. Did you forget to add readwrite capabilities? The
 | following components are allowed:
 | 	- example.QueueBlock
 | )");
	}


	template<> example::QueueBlock get<example::QueueBlock>() {
		return _ctx.get<example::QueueBlock>();
	}
	template<> void update<example::QueueBlock>(const example::QueueBlock& updated_component) {
		_ctx.update<example::QueueBlock>(updated_component);
	}
	ecsact_entity_id entity() const {
		return _ctx.entity();
	}
};

struct example::RemoveQueueBlock::context {
	[[no_unique_address]]
	::ecsact::execution_context _ctx;
	template<typename T>
	void remove() {
		// local type to make static assert always fail
		struct red_herring {};
		static_assert(std::is_same_v<T, red_herring>, R"(

 | [Ecsact C++ Error]: System Execution Context Misuse
 | 
 | example.RemoveQueueBlock context.remove<T> may only be called with a
 | component removable by the system. Did you forget to add removes capabilities? The
 | following components are allowed:
 | 	- example.QueueBlock
 | )");
	}


	template<> void remove<example::QueueBlock>() {
		return _ctx.remove<example::QueueBlock>();
	}
	ecsact_entity_id entity() const {
		return _ctx.entity();
	}
};

struct example::Move::context {
	[[no_unique_address]]
	::ecsact::execution_context _ctx;
	template<typename T>
	T get() {
		// local type to make static assert always fail
		struct red_herring {};
		static_assert(std::is_same_v<T, red_herring>, R"(

 | [Ecsact C++ Error]: System Execution Context Misuse
 | 
 | example.Move context.get<T> may only be called with a component readable by
 | the system. Did you forget to add readonly or readwrite capabilities? The
 | following components are allowed:
 | 	- example.Velocity
 | )");
	}
	template<typename T>
	void update(const T& updated_component) {
		// local type to make static assert always fail
		struct red_herring {};
		static_assert(std::is_same_v<T, red_herring>, R"(

 | [Ecsact C++ Error]: System Execution Context Misuse
 | 
 | example.Move context.update<T> may only be called with a component writable
 | by the system. Did you forget to add readwrite capabilities? The following
 | components are allowed:
 | 	- example.Velocity
 | )");
	}


	template<> example::Velocity get<example::Velocity>() {
		return _ctx.get<example::Velocity>();
	}
	template<> void update<example::Velocity>(const example::Velocity& updated_component) {
		_ctx.update<example::Velocity>(updated_component);
	}
	ecsact_entity_id entity() const {
		return _ctx.entity();
	}
	example::Move action() const {
		return _ctx.action<example::Move>();
	}
};

struct example::PerformGenerateBlock::context {
	[[no_unique_address]]
	::ecsact::execution_context _ctx;
	template<typename T>
		requires(!std::is_empty_v<T>)
	void add(const T& new_component) {
		// local type to make static assert always fail
		struct red_herring {};
		static_assert(std::is_same_v<T, red_herring>, R"(

 | [Ecsact C++ Error]: System Execution Context Misuse
 | 
 | example.PerformGenerateBlock context.add<T> may only be called with a
 | component addable by the system. Did you forget to add adds capabilities? The
 | following components are allowed:
 | 	- example.QueueBlock
 | )");
	}
	template<typename T>
	void add() {
		// local type to make static assert always fail
		struct red_herring {};
		static_assert(std::is_same_v<T, red_herring>, R"(

 | [Ecsact C++ Error]: System Execution Context Misuse
 | 
 | example.PerformGenerateBlock context.add<T> may only be called with a
 | component addable by the system. Did you forget to add adds capabilities? The
 | following components are allowed:
 | 	- example.QueueBlock
 | )");
	}


	template<> void add<example::QueueBlock>(const example::QueueBlock& new_component) {
		_ctx.add<example::QueueBlock>(new_component);
	}
	ecsact_entity_id entity() const {
		return _ctx.entity();
	}
	example::PerformGenerateBlock action() const {
		return _ctx.action<example::PerformGenerateBlock>();
	}
};
