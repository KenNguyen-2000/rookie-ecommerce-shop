import React, { useEffect, useRef } from 'react'
import Quill, { QuillOptions } from 'quill';
import { cn } from '@/lib/utils';


interface IQuillEditor {
    id?: string;
    value?: string;
    placeholder?: string;
    onChange?: (innerHtml: string, text: string) => void;
    theme?: "snow" | "bubble";
    className?: string;
    readOnly?: boolean;
    required?: boolean;
    config?: {
        toolbar?: {
            visibile: boolean;
        };
    };
    label?: string;
    errorText?: string;
}

const QuillEditor = ({
    id,
    theme = "snow",
    value = "",
    placeholder,
    onChange,
    className = "",
    readOnly = false,
    required = false,
    label,
    errorText,
    config = {
        toolbar: {
            visibile: true,
        },
    },
}: IQuillEditor) => {
    const wrapperRef = useRef<HTMLDivElement>(null);
    const editorRef = React.useRef<HTMLDivElement>(null);
    const quillInstance = React.useRef<Quill | null>(null);
    const toolbarRef = React.useRef<HTMLDivElement>(null);

    useEffect(() => {
        if (editorRef.current) {
            if (!quillInstance.current) {
                const options: QuillOptions = {
                    theme: "snow",
                    placeholder: placeholder,
                    readOnly,
                };
                const quill = new Quill(editorRef.current, options);
                quill.root.setAttribute("spellcheck", "false");
                quillInstance.current = quill;

                quill.root.innerHTML = value;
            } else if (value && !quillInstance.current.root.textContent) {
                quillInstance.current.root.innerHTML = value;
            }

            // quillInstance.current.on("text-change", handleTextChange);
        }

        return () => {
            if (quillInstance.current)
                quillInstance.current.off("text-change", () => {});
        };
    }, [placeholder, readOnly, value]);
  return (
    <div
                ref={wrapperRef}
            className={cn("flex flex-col",className)}
            >
                <div
                    ref={toolbarRef}
                >
                </div>
                <div className={cn("relative flex-1 flex flex-col",)}>
                    <div
                        ref={editorRef}
                       className='!flex-1'
                    ></div>
                </div>
                {errorText && (
                    <p className="mt-2 text-sm text-red-600 dark:text-red-500">
                        <span className="font-medium">{errorText}</span>
                    </p>
                )}
                <input id={id} className="sr-only" readOnly />
            </div>
  )
}

export default QuillEditor