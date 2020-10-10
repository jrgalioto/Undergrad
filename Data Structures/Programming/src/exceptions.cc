#include "exceptions.h"




const string Exception::toString(void) {
	string
	msg;

	if (source().length() > 0)
		msg = source() + ":_";
	else
		msg += "generic_exception";

	return msg;

}

const string ContainerEmptyException::toString(void) {
	string
		msg;

	if (source().length() > 0)
		msg = source() + ":_";
	else
		msg += "container_empty";

	return msg;
}




