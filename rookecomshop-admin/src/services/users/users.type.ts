import { Gender } from './users.enum';

export type UserDto = {
	id: string;
	firstName: string;
	lastName: string;
	phoneNumber?: string;
	address?: string;
	dob?: string;
	gender: Gender;
	avatarUrl?: string;
};
