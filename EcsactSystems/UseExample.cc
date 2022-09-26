#include "example.ecsact.hh"
#include "example.ecsact.systems.hh"

void example::UseExample(UseExample::context& ctx) {
	auto example = ctx.get<Example>();

	example.example_value +=1;
	ctx.update(example);
}
