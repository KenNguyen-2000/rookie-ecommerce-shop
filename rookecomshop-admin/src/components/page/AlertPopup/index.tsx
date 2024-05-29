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
	closeModal: () => void;
};

const AlertPopup: FC<AlertPopupProps> = ({
	open,
	title,
	description,
	confirmAction,
	closeModal,
}) => {
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
					<AlertDialogCancel onClick={closeModal}>Cancel</AlertDialogCancel>
					<AlertDialogAction onClick={confirmAction}>Continue</AlertDialogAction>
				</AlertDialogFooter>
			</AlertDialogContent>
		</AlertDialog>
	);
};

export default AlertPopup;
