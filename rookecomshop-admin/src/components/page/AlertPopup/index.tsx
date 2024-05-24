import {
	AlertDialog,
	AlertDialogAction,
	AlertDialogCancel,
	AlertDialogContent,
	AlertDialogDescription,
	AlertDialogFooter,
	AlertDialogHeader,
	AlertDialogTitle,
} from '@/components/ui/alert-dialog';
import { FC } from 'react';

type AlertPopupProps = {
	open: boolean;
	title?: string;
	description?: string;
	confirmAction: (args?: any) => void;
};

const AlertPopup: FC<AlertPopupProps> = ({ open, title, description, confirmAction }) => {
	return (
		<AlertDialog open={open}>
			<AlertDialogContent>
				<AlertDialogHeader>
					<AlertDialogTitle>{title ?? 'Are you absolutely sure?'}</AlertDialogTitle>
					<AlertDialogDescription>
						{description ??
							`This action cannot be undone. This will permanently delete your
              account and remove your data from our servers.`}
					</AlertDialogDescription>
				</AlertDialogHeader>
				<AlertDialogFooter>
					<AlertDialogCancel>Cancel</AlertDialogCancel>
					<AlertDialogAction onClick={confirmAction}>Continue</AlertDialogAction>
				</AlertDialogFooter>
			</AlertDialogContent>
		</AlertDialog>
	);
};

export default AlertPopup;
