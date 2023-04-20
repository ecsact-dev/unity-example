#include "example.ecsact.hh"
#include "example.ecsact.systems.hh"

// The system implement of our AddToExample system
void example::AddToExample::impl(context& ctx) {
	// Get a component from the context
	auto value = ctx.get<Example>();
	
	// Modify and update its value
	value.example_value +=1;
	ctx.update<Example>(value);

	if(value.example_value >= 100) {
		// Remove the component from the context
		ctx.remove<ToBeRemoved>();
	}
}
