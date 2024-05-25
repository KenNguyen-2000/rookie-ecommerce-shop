import { FC, ReactNode } from 'react';
import { ErrorBoundary } from 'react-error-boundary';

type ErrorHandleProviderProps = {
	children: ReactNode;
};

const ErrorHandleProvider: FC<ErrorHandleProviderProps> = ({ children }) => {
	// function fallbackRender({ error, resetErrorBoundary }) {
	//     // Call resetErrorBoundary() to reset the error boundary and retry the render.

	//     return (
	//       <div role="alert">
	//         <p>Something went wrong:</p>
	//         <pre style={{ color: "red" }}>{error.message}</pre>
	//       </div>
	//     );
	//   }
	return <ErrorBoundary fallback={<div>Something went wrong</div>}>{children}</ErrorBoundary>;
};

export default ErrorHandleProvider;
